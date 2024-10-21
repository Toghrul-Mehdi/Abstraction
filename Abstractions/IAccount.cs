using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
        
    }
}
