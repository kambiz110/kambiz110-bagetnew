using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Token
{
  public interface IGetUserToken
    {
        string getToken(string usernane);
    }
    public class GetUserToken : IGetUserToken
    {
        private readonly IIdentityDatabaseContext context;
        public GetUserToken(IIdentityDatabaseContext context)
        {
            this.context = context;
        }



        public string getToken(string usernane)
        {
            var user = context.Users.Include(p => p.UserTokens).FirstOrDefault(p => p.UserName == usernane);
            if (user!=null && user.UserTokens!=null)
            {
                return user.UserTokens.Value;
            }
            return null;
        }
    }
}
