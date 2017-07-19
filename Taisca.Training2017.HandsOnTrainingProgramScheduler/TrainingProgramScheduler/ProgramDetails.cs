using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramScheduler
{
    class ProgramDetails
    {
        private static int idIndex=0;
        private string programName;
        private DateTime progDate;
        private string beginningTime;
        private string duration;
        private string trainer;
        private string scheduler;
        private string status;
        private string audience;
        private string remarks;
        private string progId;
        public ProgramDetails()
        {

        }
        public ProgramDetails(string pname,DateTime pdate,string btime,string dur,string trainr,string schedulr,string stats,string aud,string remark, string pid)
        {
            programName = pname;
            progDate = pdate;
            beginningTime = btime;
            duration = dur;
            trainer = trainr;
            scheduler = schedulr;
            status = stats;
            audience = aud;
            remarks = remark;
            progId = pid;
        }
        public void NewProgram()
        {
            string date;
            Console.WriteLine("Enter the program name");
            this.programName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the date of the program in the format yyyy/mm/dd");
            date = Console.ReadLine();
            string[] dat = date.Split('/');
           this.progDate = new DateTime(Convert.ToInt32(dat[0]), Convert.ToInt32(dat[1]), Convert.ToInt32(dat[2]));
            Console.WriteLine();
            Console.WriteLine("Enter the beginning of the program time in the format hh:mm");
            this.beginningTime =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the duration of the program in the format hh:min");
            this.duration =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the trainer name");
            this.trainer =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the scheduler name");
            this.scheduler =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the status of the program");
            this.status =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the audience categories eligible for this program separated by ',' ");
            this.audience =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter any remarks if present else write no remarks");
            this.remarks =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the program ID");
            this.progId=Console.ReadLine();
        }
        public bool GetProgId(string checkId)
        {
            //for(int i=0;i<idIndex;i++)
           // {
               if (checkId.Equals(progId))
                {
                    return true;
                }
            
            return false;
        }
        public void GetDetails()
        {
            Console.WriteLine("Program ID: " + this.progId);
            Console.WriteLine("Program name: " + this.programName);
            Console.WriteLine("Program Date: " + this.progDate.ToString());
            Console.WriteLine("Program Duration: " + this.duration);
            Console.WriteLine("Trainer assigned: " + this.trainer);
            Console.WriteLine("Scheduled by : " + this.scheduler);
            Console.WriteLine("Audience eligible for this program:" + this.audience);
            Console.WriteLine("Program Status: " + this.status);
            Console.WriteLine("Remarks: " + this.remarks);
        }
        public void UpdateDetail()
        {
            Console.WriteLine("Enter the details to update status");
            this.status = Console.ReadLine();
        }
    }
}
