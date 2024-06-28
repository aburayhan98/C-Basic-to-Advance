using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKeyWord
{
   public class Member : User
    {
        public new void GenerateId()  //remove the greenline by using new keyword because we use the same method name,to justify the duplicate 
        {
            Console.WriteLine("Generate Id in Member");
            base.GenerateId(); //call its parent class
        }
    }
}
//basically it will use to elemenate warning which is not logically error but showing a greenline under the method name
// to confusing this problem we will use new keyword through The output will remain same