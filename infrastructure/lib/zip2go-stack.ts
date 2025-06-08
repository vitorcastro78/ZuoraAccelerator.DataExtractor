import * as cdk from 'aws-cdk-lib';
import * as ec2 from 'aws-cdk-lib/aws-ec2';
import * as ecs from 'aws-cdk-lib/aws-ecs';
import * as ecr from 'aws-cdk-lib/aws-ecr';
import * as iam from 'aws-cdk-lib/aws-iam';
import * as logs from 'aws-cdk-lib/aws-logs';
import * as elbv2 from 'aws-cdk-lib/aws-elasticloadbalancingv2';
import * as ssm from 'aws-cdk-lib/aws-ssm';
import { Construct } from 'constructs';

export class Zip2GoStack extends cdk.Stack {
  constructor(scope: Construct, id: string, props?: cdk.StackProps) {
    super(scope, id, props);

    // VPC
    const vpc = new ec2.Vpc(this, 'Zip2GoVpc', {
      maxAzs: 2,
      natGateways: 1,
    });

    // ECS Cluster
    const cluster = new ecs.Cluster(this, 'Zip2GoCluster', {
      vpc,
      clusterName: 'zip2go-cluster',
    });

    // ECR Repository
    const repository = new ecr.Repository(this, 'Zip2GoRepository', {
      repositoryName: 'zip2go',
      removalPolicy: cdk.RemovalPolicy.RETAIN,
    });

    // Task Execution Role
    const taskExecutionRole = new iam.Role(this, 'Zip2GoTaskExecutionRole', {
      assumedBy: new iam.ServicePrincipal('ecs-tasks.amazonaws.com'),
      managedPolicies: [
        iam.ManagedPolicy.fromAwsManagedPolicyName('service-role/AmazonECSTaskExecutionRolePolicy'),
      ],
    });

    // Task Role
    const taskRole = new iam.Role(this, 'Zip2GoTaskRole', {
      assumedBy: new iam.ServicePrincipal('ecs-tasks.amazonaws.com'),
    });

    // Add permissions to access SSM parameters
    taskRole.addToPolicy(
      new iam.PolicyStatement({
        effect: iam.Effect.ALLOW,
        actions: ['ssm:GetParameter', 'ssm:GetParameters'],
        resources: [
          `arn:aws:ssm:${this.region}:${this.account}:parameter/zip2go/*`,
        ],
      })
    );

    // CloudWatch Log Group
    const logGroup = new logs.LogGroup(this, 'Zip2GoLogGroup', {
      logGroupName: '/ecs/zip2go',
      retention: logs.RetentionDays.ONE_MONTH,
      removalPolicy: cdk.RemovalPolicy.DESTROY,
    });

    // Load Balancer
    const alb = new elbv2.ApplicationLoadBalancer(this, 'Zip2GoAlb', {
      vpc,
      internetFacing: true,
    });

    const listener = alb.addListener('Zip2GoListener', {
      port: 443,
      certificates: [
        // Add your certificate here
      ],
    });

    // ECS Service
    const service = new ecs.FargateService(this, 'Zip2GoService', {
      cluster,
      serviceName: 'zip2go-service',
      taskDefinition: new ecs.FargateTaskDefinition(this, 'Zip2GoTask', {
        memoryLimitMiB: 512,
        cpu: 256,
        executionRole: taskExecutionRole,
        taskRole: taskRole,
      }),
      desiredCount: 2,
      assignPublicIp: false,
      securityGroups: [
        new ec2.SecurityGroup(this, 'Zip2GoServiceSG', {
          vpc,
          allowAllOutbound: true,
        }),
      ],
    });

    // Add container to task definition
    const container = service.taskDefinition.addContainer('Zip2GoContainer', {
      image: ecs.ContainerImage.fromEcrRepository(repository),
      logging: ecs.LogDrivers.awsLogs({
        streamPrefix: 'ecs',
        logGroup,
      }),
      environment: {
        ASPNETCORE_ENVIRONMENT: 'Production',
      },
      secrets: {
        'Zuora__ClientId': ecs.Secret.fromSsmParameter(
          ssm.StringParameter.fromStringParameterName(
            this,
            'ZuoraClientId',
            '/zip2go/zuora/clientid'
          )
        ),
        'Zuora__ClientSecret': ecs.Secret.fromSsmParameter(
          ssm.StringParameter.fromStringParameterName(
            this,
            'ZuoraClientSecret',
            '/zip2go/zuora/clientsecret'
          )
        ),
      },
    });

    container.addPortMappings(
      { containerPort: 80 },
      { containerPort: 443 }
    );

    // Add target group to ALB
    const targetGroup = listener.addTargets('Zip2GoTargetGroup', {
      port: 80,
      targets: [service],
      healthCheck: {
        path: '/health',
        interval: cdk.Duration.seconds(30),
        timeout: cdk.Duration.seconds(5),
        healthyHttpCodes: '200',
      },
    });

    // Outputs
    new cdk.CfnOutput(this, 'LoadBalancerDNS', {
      value: alb.loadBalancerDnsName,
    });

    new cdk.CfnOutput(this, 'RepositoryURI', {
      value: repository.repositoryUri,
    });
  }
} 