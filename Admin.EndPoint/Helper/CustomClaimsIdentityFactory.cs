using Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Admin.EndPoint.Helper
{
    public class CustomClaimsIdentityFactory : UserClaimsPrincipalFactory<User>
    {
        public CustomClaimsIdentityFactory(UserManager<User> userManager
            , IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
        {
        }

        public async override Task<ClaimsPrincipal> CreateAsync(User user)
        {
            var principal = await base.CreateAsync(user);
            //custom claims
            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
          new Claim(ClaimTypes.GivenName, user.FullName)
          });
            return principal;
        }
    }
}
