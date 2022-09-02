using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SMS
{
    public interface ISmsServices
    {
        public Task singleUserSendSMS(string message, string[] phonNumber);
        public Task verificationCodeWithPatern(string name, string Mobile ,string smsCode);
    }
    public class SmsServices : ISmsServices
    {
        public async Task singleUserSendSMS(string message, string[] phonNumber)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";
            DateTime SendDateTime = DateTime.Now;

            string LineNumber = "Public";
            string[] Mobiles = new string[]
            {
            "09055510734",
            };

            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
               "https://portal.amootsms.com/webservice2.asmx");
            // AmootSMS.SendOTPResult result2 = client.SendQuickOTPAsync(UserName, Password, "09055510734", 4, "2233").Result;

            var result = await client.SendSimpleAsync(UserName, Password, SendDateTime, message, LineNumber, phonNumber);

            if (result.Status == AmootSMS.Status.Success)
            {
                var b = "ارسال ";
            }
            else
            {
                var a = "ارسال نشد";
            }




        }
        public async Task verificationCodeWithPatern(string name, string Mobile, string smsCode)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";
            string verificationCode = smsCode;

            int PatternCodeID = 1225;
            string[] PatternValues = new string[] { name, verificationCode };
            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                    AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
                   "https://portal.amootsms.com/webservice2.asmx");
          /*  AmootSMS.SendResult result =*/ await client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

       
        }


    }

}
