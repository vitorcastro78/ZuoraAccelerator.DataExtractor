using Service.Models;

namespace Service.Interfaces
{
    public interface ISubscriptionPlansService
    {
        void FillSubscriptionPlansTabled();
        SubscriptionPlan GetSubscriptionPlan(string subscriptionPlanId, string zuoraTrackId, bool? async);
        SubscriptionPlanListResponse GetSubscriptionPlans(string zuoraTrackId, bool? async);
    }
}