using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PartialExamples
{
    public class Admin  //multiple inheritance
    {
        public string Key { get; set; }
    }
}

//It will build faild or cannot access in program because multiple inheritance not possible in partial class