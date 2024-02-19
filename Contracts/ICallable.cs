using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Management_System.Contracts
{
    public interface ICallable
    {
        string Call(string phoneNumber);
    }
}
