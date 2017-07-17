using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramScheduler
{
    class DispalyMessage
    {
        public void Display()
        {
            Console.WriteLine("Incorrect Program Id");
        }
        public void DisplayWrongUser()
        {
            Console.WriteLine("Wrong username or Password");
            Console.WriteLine("Enter 0 to renter or 1 to exit");
        }
    }
}
