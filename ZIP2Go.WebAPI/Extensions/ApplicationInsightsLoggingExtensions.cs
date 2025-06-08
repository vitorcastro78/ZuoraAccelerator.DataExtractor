using Microsoft.AspNetCore.Builder;

namespace DataExtractor.WebAPI.Extensions;

public static class ApplicationInsightsLoggingExtensions
{
    public static IApplicationBuilder UseApplicationInsightsLogging(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ApplicationInsightsLoggingMiddleware>();
    }
} 