using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter admin username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            AdminDetails admindeatils = new AdminDetails();
            ProgramDetails programdetails = new ProgramDetails();
            bool flag = true;

                if (admindeatils.Authentication(username, password))
                {
                while (flag)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter 1:To add a program  2. To Track a Program  3. To Update Details of a Program  4. To Exit");
                    Console.WriteLine();
                    Console.WriteLine();
                    int option;
                    Int32.TryParse(Console.ReadLine(), out option);
                    switch (option)
                    {
                        case 1:
                            programdetails.NewProgram();
                            break;
                        case 2:
                            EnterProgId enterId = new EnterProgId();
                            enterId.EnterId(programdetails, option);
                            break;
                        case 3:
                            EnterProgId enterID = new EnterProgId();
                            enterID.EnterId(programdetails, option);
                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Inalid Entry");
                            break;

                    }
                }
                }
            else
            {
                DispalyMessage display = new DispalyMessage();
                display.DisplayWrongUser();
            }
            Console.WriteLine("Program has stopped.");
            Console.WriteLine("Press any key to exit console");
            Console.ReadLine();
        }
    }
}