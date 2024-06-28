using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    [Obsolete]  //when we don't want to use previous method in future,here Sendemail is obsolete
    public class TextEmailSender : IWelcomeEmailSender
    {
        public void SendEmail(string email,string subject, string body)
        {

        } 
        public void Send(string email, string password, string body) 
        {
            SendEmail(email,password,body);
        }
        public void SendWelcomeEmail (string email)
        {
            SendEmail(email, "Hello", "Welcome");
        }
    }
}
