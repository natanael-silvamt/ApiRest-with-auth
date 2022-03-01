using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace api_with_auth.Authorization
{
    public class PermissionsMiddleware
    {
        private readonly RequestDelegate _next;

        public PermissionsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.User.Identity == null)
            {
                await _next(context);
                return;
            }

            var invalidToken = context.RequestAborted;

            // var userSub = context.User.FindFirst(StandardJwtClaimTypes);
        }
    }
}
