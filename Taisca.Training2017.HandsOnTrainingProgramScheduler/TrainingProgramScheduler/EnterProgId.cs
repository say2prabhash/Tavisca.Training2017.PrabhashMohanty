using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramScheduler
{
    class EnterProgId
    {
        public bool EnterId(ProgramDetails programdetails,int check)
        {
            Console.WriteLine("Enter the program Id");
            string pid = Console.ReadLine();
            Matching_Details match= new Matching_Details();
            if(match.MatchingDetails(programdetails,pid, check))
            {
                return true;
            }
            else
            {
                DispalyMessage display = new DispalyMessage();
                display.Display();
                return false;
            }
        }
       
    }
}
