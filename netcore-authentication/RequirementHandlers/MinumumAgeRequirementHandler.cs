using Microsoft.AspNetCore.Authorization;
using netcoreAuthentication.Requirements;
using System.Threading.Tasks;

namespace netcoreAuthentication.Infrastructure.Authorization
{
    public class MinumumAgeRequirementHandler : AuthorizationHandler<MinumumAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                          MinumumAgeRequirement requirement)
        {
            //TODO : permission var mı kontrol et
            context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}