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
            if(MatchingDetails(programdetails,pid, check))
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
        public bool MatchingDetails(ProgramDetails programdetails,string pid,int check)
        { 
           // ProgramDetails programdetails = new ProgramDetails();
            if(programdetails.GetProgId(pid))
            {
                if(check==2)
                {
                    Tracker tracking = new Tracker();
                    tracking.DisplayDetails(programdetails);
                }
                if(check==3)
                {
                    StatusUpdation update = new StatusUpdation();
                    update.UpdateDetails(programdetails);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
