using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramScheduler
{
    class AdminDetails
    {
        private string username = "PRABHASH";
        private string password = "1234";
        public bool Authentication(string user,string pass)
        {
            if(user.Equals(username)&&pass.Equals(password))
            {
                return true;
            }
            else
            {
                DispalyMessage display = new DispalyMessage(); 
                display.DisplayWrongUser();
                return false;
            }
        }
    }
}
