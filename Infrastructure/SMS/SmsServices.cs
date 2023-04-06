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
        public void newTicket(string name, string ticket_number, string status, string Mobile);
        public Task TicketStatAsync(string name, string status, string Mobile);
        public Task newTicketAsync(string name, string ticket_number, string status, string Mobile);
        public void newBuy(string username, string number,string amount,  string status, string Mobile);
        public Task newBuyAsync(string username, string number, string amount, string status, string Mobile);
        public Task SuccessBuyCustomerAsync(string name, string Mobile);
        public Task SendPostalProductAsync(string name,string postcode, string postcompanyname, string Mobile);
    }
    public class SmsServices : ISmsServices
    {
        public void newBuy(string username, string number, string amount, string status, string Mobile)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";
        

            int PatternCodeID = 1387;
            string[] PatternValues = new string[] { username, number , amount, status };
            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                    AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
                   "https://portal.amootsms.com/webservice2.asmx");
            /*  AmootSMS.SendResult result =*/
             client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

        }

        public void newTicket(string name, string ticket_number, string status, string Mobile)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";


            int PatternCodeID = 1386;
            string[] PatternValues = new string[] { name, ticket_number, status };
            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                    AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
                   "https://portal.amootsms.com/webservice2.asmx");
            /*  AmootSMS.SendResult result =*/
             client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

        }
        public async Task newTicketAsync(string name, string ticket_number, string status, string Mobile)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";


            int PatternCodeID = 1386;
            string[] PatternValues = new string[] { name, ticket_number, status };
            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                        AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
                       "https://portal.amootsms.com/webservice2.asmx");
            /*  AmootSMS.SendResult result =*/
            await client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

        }
        public async Task TicketStatAsync(string name, string status, string Mobile)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";


            int PatternCodeID = 1617;
            string[] PatternValues = new string[] { name, status };
            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                        AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
                       "https://portal.amootsms.com/webservice2.asmx");
            /*  AmootSMS.SendResult result =*/
            await client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

        }
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
          /*  AmootSMS.SendResult result =*/
            await client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

       
        }
        public async Task newBuyAsync(string username, string number, string amount, string status, string Mobile)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";


            int PatternCodeID = 1387;
            string[] PatternValues = new string[] { username, number, amount, status };
            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                       AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
                      "https://portal.amootsms.com/webservice2.asmx");
            /*  AmootSMS.SendResult result =*/
            await client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

        }
        public async Task SuccessBuyCustomerAsync(string name, string Mobile)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";


            int PatternCodeID = 1230;
            string[] PatternValues = new string[] { name };
            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                        AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
                       "https://portal.amootsms.com/webservice2.asmx");
            /*  AmootSMS.SendResult result =*/
            await client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

        }
        public async Task SendPostalProductAsync(string name, string postcode, string postcompanyname, string Mobile)
        {
            string UserName = "09108496094";
            string Password = "karen@1397";


            int PatternCodeID = 1616;
            string[] PatternValues = new string[] { name , postcode , postcompanyname };
            var client = new AmootSMS.AmootSMSWebService2SoapClient(
                        AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
                       "https://portal.amootsms.com/webservice2.asmx");
            /*  AmootSMS.SendResult result =*/
            await client.SendWithPatternAsync(UserName, Password, Mobile, PatternCodeID, PatternValues);

        }
    }

}
