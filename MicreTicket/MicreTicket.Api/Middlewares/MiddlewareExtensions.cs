using Microsoft.AspNetCore.Builder;

namespace MicreTicket.Api.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseTest(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TestMiddleware>();
        }
    }
}
