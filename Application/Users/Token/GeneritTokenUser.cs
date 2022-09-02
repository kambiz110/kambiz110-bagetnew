using Application.Interfaces.Contexts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Users;
using Application.Dtos;

namespace Application.Users.Token
{
    public interface IGeneritTokenUser {
        ResultDto<string> creatToken(string userId);
    }
   public class GeneritTokenUser: IGeneritTokenUser
    {
        private readonly IIdentityDatabaseContext context;

        public GeneritTokenUser(IIdentityDatabaseContext _context)
        {
            context = _context;
        }
        public ResultDto<string> creatToken(string userId)
        {
            var user = context.Users.AsNoTracking().Include(p=>p.UserTokens).FirstOrDefault(p => p.Id == userId);
            if (user!=null)
            {

                var token = generateJwtToken(userId);
                if (user.UserTokens==null)
                {
                    UserTokens ut = new UserTokens {UserId=user.Id , LoginProvider="yadakcarshop" ,Name=user.UserName , Value=token };
                    user.UserTokens = ut;
                }
                user.UserTokens.Value = token;
                context.UserTokens.Update(user.UserTokens);
                var result = context.SaveChanges();
                return new ResultDto<string>
                {
                    IsSuccess = true,
                    Data = token
                };
            }
            return new ResultDto<string> { 
            IsSuccess=false,
            Data=""
            };
        }

        private string generateJwtToken(string userId)
        {
            var Key = "vsdho%^GDD+-*/jhdif@$WGHBCY^";
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            // Here you  can fill claim information from database for the users as well
            var claims = new[] {
                new Claim("id", userId),
                    new Claim(JwtRegisteredClaimNames.Sub, "atul"),
                    new Claim(JwtRegisteredClaimNames.Email, ""),
                    new Claim("Role", "Admin"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken("Kardin.group", "Kardin.group", claims, expires: DateTime.Now.AddHours(24), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
