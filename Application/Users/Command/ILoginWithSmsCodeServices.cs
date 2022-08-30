using Application.Dtos;
using Application.Interfaces.Contexts;
using Domain.Users;
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
        ResultDto<string> LoginWithSmsCode(string phoneNumber, string Code);
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
            var user = identityDatabase.Users.SingleOrDefault(p => p.PhoneNumber.Equals(phoneNumber));
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

        public ResultDto<string> LoginWithSmsCode(string phoneNumber, string Code)
        {
            var smsCode = _context.SmsCodes.Where(p => p.PhoneNumber == phoneNumber).OrderByDescending(p => p.Id)
            .FirstOrDefault();

            if (smsCode == null || smsCode.Code != Code)
            {
                return new ResultDto<string>
                {
                    IsSuccess = false,
                    Message = "کد وارد شده صحیح نیست!",

                };
            }
            else
            {
                if (smsCode.Used == true || smsCode.RequestCount > 3)
                {
                    return new ResultDto<string>
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
                var user = identityDatabase.Users.SingleOrDefault(p => p.PhoneNumber.Equals(phoneNumber));
                if (user != null)
                {
                    return new ResultDto<string>
                    {
                        IsSuccess = true,
                        Data = user.Id,
                    };
                }
                else
                {
                  
                    return new ResultDto<string>
                    {
                        Data = user.Id,
                        IsSuccess = true,
                        Message = "موفق"
                    };
                }

            }
            
        }
    }
}
