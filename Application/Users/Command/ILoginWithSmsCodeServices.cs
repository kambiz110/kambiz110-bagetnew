using Application.Dtos;
using Application.Interfaces.Contexts;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Command
{
   public interface ILoginWithSmsCodeServices
    {
        string GetCode(string PhoneNumber);
        ResultDto<User> LoginWithSmsCode(string phoneNumber, string Code, string token, string tokencreator);
        ResultDto<User> FindUserWithPhonenumber(string phoneNumber);
    }
   public class LoginWithSmsCodeServices : ILoginWithSmsCodeServices
    {
        private readonly IDataBaseContext _context;
        private readonly IIdentityDatabaseContext identityDatabase;

        public LoginWithSmsCodeServices(IDataBaseContext context , IIdentityDatabaseContext _identityDatabase)
        {
            _context = context;
            identityDatabase = _identityDatabase;
        }

        public ResultDto<User> FindUserWithPhonenumber(string phoneNumber)
        {
            var user = identityDatabase.Users.AsNoTracking().Where(p => p.PhoneNumber.Equals(phoneNumber)).FirstOrDefault();
            return new ResultDto<User>
            {
                IsSuccess = user!=null? true:false,
                Data = user,
            };
        }

        public string GetCode(string PhoneNumber)
        {
            Random random = new Random();
            string code = random.Next(1000, 9999).ToString();
            SmsCode smsCode = new SmsCode()
            {
                Code = code,
                InsertDate = DateTime.Now,
                PhoneNumber = PhoneNumber,
                RequestCount = 0,
                Used = false,
            };
            _context.SmsCodes.Add(smsCode);
            _context.SaveChanges();

            return code;
        }

        public ResultDto<User> LoginWithSmsCode(string phoneNumber, string Code, string token, string tokencreator)
        {
            var smsCode = _context.SmsCodes.AsNoTracking().Where(p => p.PhoneNumber == phoneNumber).OrderByDescending(p => p.Id)
            .FirstOrDefault();
            var tokenUser = identityDatabase.UserTokens.AsNoTracking().Where(p=>p.UserId==tokencreator).FirstOrDefault();
            if (smsCode == null || tokenUser==null)
            {
                return new ResultDto<User>
                {
                    IsSuccess = false,
                    Message = "کد وارد شده صحیح نیست!",

                };
            }
            else
            {
                if ( smsCode.Code != Code || tokenUser.Value!= token)
                {
                    smsCode.RequestCount++;
                    _context.SaveChanges();
                    return new ResultDto<User>
                    {
                        IsSuccess = false,
                        Message = "کد وارد شده صحیح نیست!",

                    };
                }
                if (smsCode.Used == true || smsCode.RequestCount > 3)
                {
                    return new ResultDto<User>
                    {
                        IsSuccess = false,
                        Message = "کد وارد شده صحیح نیست!",

                    };
                }
                ////
                ///
                smsCode.RequestCount++;

                smsCode.Used = true;
                _context.SaveChanges();
                var user = identityDatabase.Users.AsNoTracking().Where(p => p.PhoneNumber.Equals(phoneNumber)).FirstOrDefault();
                if (user != null)
                {
                    return new ResultDto<User>
                    {
                        IsSuccess = true,
                        Data = user,
                    };
                }
                else
                {
                  
                    return new ResultDto<User>
                    {
                      
                        IsSuccess = false,
                        Message = "ناموفق کاربر یافت نشد!!!"
                    };
                }

            }
            
        }
    }
}
