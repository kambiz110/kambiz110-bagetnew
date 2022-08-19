using Domain.Attributes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Users
{
    [Auditable]
    public class User : IdentityUser<string>
    {
        public string FullName { get; set; }
        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
        public virtual UserTokens UserTokens { get; set; }
    }
}
