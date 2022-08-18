using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Helper
{
    public class addsmsService
    {
        public async void singleUserSendSMS(string message, string[] phonNumber)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";
            DateTime SendDateTime = DateTime.Now;
           
            string LineNumber = "Public";
            string[] Mobiles = new string[]
            {
            "09055510734",
            };

           // AmootSMS.AmootSMSWebService2SoapClient client2 = new AmootSMS.AmootSMSWebService2SoapClient("AmootSMSWebService2Soap12");

            //var client = new AmootSMS.AmootSMSWebService2SoapClient(
            //    AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
            //   "https://portal.amootsms.com/webservice2.asmx");
            //AmootSMS.SendOTPResult result2 = client.SendQuickOTPAsync(UserName, Password, "09055510734", 4, "2233").Result;

            //var result = await client.SendSimpleAsync(UserName, Password, SendDateTime, message, LineNumber, phonNumber);

            //if (result.Status == AmootSMS.Status.Success)
            //{
            //    var b = "ارسال ";
            //}
            //else
            //{
            //    var a = "ارسال نشد";
            //}

        


        }
    }
}
