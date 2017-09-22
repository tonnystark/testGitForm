using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitForm.Services
{
    class AccountService
    {
        public bool KiemTraChanLe(int n)
        {
            return n % 2 == 0;
        }
    }
}
