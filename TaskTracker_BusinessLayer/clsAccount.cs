using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker_DataLayer;

namespace TaskTracker_BusinessLayer
{
    public class clsAccount
    {
        public static bool FindByUsernameAndPassword(string Username, string Password)
        {
            return clsAccount_DataAccess.FindAccountByUsernameAndPassword(Username, Password);
        }
    }
}
