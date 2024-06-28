using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public interface IEmailSender
    {
         void Send(string email, string password, string body);
       
    }
}

/*
 * keep only abstract method which doesn't have any implementation
 * interface can be use for keep the signature method
 * multiple interface can be added
 * it can be static because no instance can be created
 * default implementation
 * we cannot declare Constructor/build/field in Interface and also the variable
 * cannot create instance in interface
 * An interface can be implemented another interface
 */
