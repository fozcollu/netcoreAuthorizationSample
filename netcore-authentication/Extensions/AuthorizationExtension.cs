using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection;

using netcoreAuthentication.Infrastructure.Authorization;

namespace netcoreAuthentication.Extensions
{
    public static class AuthorizationExtension
    {
        public static void AddCustomAuthorization(this IServiceCollection services)
        {
            var policyBuilder = new AuthorizationPolicyBuilder();
            policyBuilder.Requirements.Add(new GeneralRequirement());
            var policy = policyBuilder.Build();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("GeneralPolicy", policy);
            });

            services.AddMvc(mvc =>
            {
                mvc.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddSingleton<IAuthorizationHandler, PermissionHandler>();
        }
    }
}