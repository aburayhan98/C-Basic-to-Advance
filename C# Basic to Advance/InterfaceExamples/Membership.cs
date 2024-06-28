using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Membership
    {
        private readonly IWelcomeEmailSender _emailSender;  //dependency
        public Membership(IWelcomeEmailSender emailSender)  //dependency injection,it is use in constructor
        {
            _emailSender = emailSender;
        }
        public void Signup(string email, string password)
        {
            CreateUser(email, password);
        }

        private void CreateUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}

//