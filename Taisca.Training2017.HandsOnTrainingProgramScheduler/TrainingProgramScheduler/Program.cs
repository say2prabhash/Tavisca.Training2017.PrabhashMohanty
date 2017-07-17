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
            Console.WriteLine("Do you want to begin as Admin or a Visitor");
            string user = Console.ReadLine();
            user=user.ToUpper();
            if (user.Equals("ADMIN"))
            {
                Console.WriteLine("Enter admin username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                AdminDetails admindeatils = new AdminDetails();
                ProgramDetails programdetails = new ProgramDetails();
                bool flag = true;
                int exit = 0;
                while (exit == 0)
                {
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
                        exit = Convert.ToInt32(Console.ReadLine());
                    }
                   
                }
                Console.WriteLine("Program has stopped.");
                Console.WriteLine("Press any key to exit console");
                Console.ReadLine();
            }

            else if (user.Equals("VISITOR"))
            {
                DateTime dt = DateTime.Today;
                ProgramDetails programdetails = new ProgramDetails("abcd", dt, "10:00 AM", "2:00", "Prabhash", "Prabhash", "open", "Everyone", "No Remarks", "p123");
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter 2. To Track a Program  3. To Update Details of a Program  4. To Exit");
                    Console.WriteLine();
                    Console.WriteLine();
                    int option;
                    Int32.TryParse(Console.ReadLine(), out option);
                    switch (option)
                    {
                        case 2:
                            EnterProgId enterId = new EnterProgId();
                            enterId.EnterId(programdetails, option);
                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Inalid Entry");
                            break;

                    }
                }
                Console.WriteLine("Program has stopped.");
                Console.WriteLine("Press any key to exit console");
                Console.ReadLine();
            }
        }
    }
}