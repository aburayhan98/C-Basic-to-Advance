using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum Status
    {
         
        Pending,
        Active = 3,
        Blocked,
        Deleted
    }

    
}
//If we don't set value in enum, It will be placed in increment order