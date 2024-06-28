using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public interface IWelcomeEmailSender : IEmailSender
    {
        public void SendWelcomeEmail(string email)
        {
            Console.WriteLine($"Sending Welcome Email to {email}");
        }
    }
}
