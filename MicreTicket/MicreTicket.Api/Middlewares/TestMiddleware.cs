using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MicreTicket.Api.Middlewares
{
    public class TestMiddleware
    {
        private RequestDelegate next;
        public TestMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await next(context);
        }
    }
}
