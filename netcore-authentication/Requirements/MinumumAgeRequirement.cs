using Microsoft.AspNetCore.Authorization;

namespace netcoreAuthentication.Requirements
{
    public class MinumumAgeRequirement : IAuthorizationRequirement
    {
        public int MinimumAge { get; }

        public MinumumAgeRequirement(int minimumAge)
        {
            MinimumAge = minimumAge;
        }
    }
}