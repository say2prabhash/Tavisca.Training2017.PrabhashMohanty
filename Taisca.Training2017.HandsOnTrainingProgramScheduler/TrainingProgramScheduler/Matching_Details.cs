using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramScheduler
{
    class Matching_Details
    {
        public bool MatchingDetails(ProgramDetails programdetails, string pid, int check)
        {
            // ProgramDetails programdetails = new ProgramDetails();
            if (programdetails.GetProgId(pid))
            {
                if (check == 2)
                {
                    Tracker tracking = new Tracker();
                    tracking.DisplayDetails(programdetails);
                }
                if (check == 3)
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
