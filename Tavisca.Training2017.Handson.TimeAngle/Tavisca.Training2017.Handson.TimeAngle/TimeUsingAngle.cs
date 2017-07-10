using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Handson.TimeAngle
{
    public class TimeUsingAngle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the degree value to find time");
            double theta = Convert.ToDouble(Console.ReadLine());
            double hrspeed = 360.0 / (60 * 12 * 60);
            double minspeed = 360.0 / (60 * 60);
            double relspeed = 360.0 / ((minspeed - hrspeed) * 60 * 60);

            for (double t = 0; t <= 12; t += relspeed)
            {
                double time1 = t + theta / ((minspeed - hrspeed) * 60 * 60);
                double time2 = t + (360 - theta) / ((minspeed - hrspeed) * 60 * 60);

                if (theta == 0 || theta == 180)
                {
                    TimeFinder(time1);
                }
                else
                {
                    TimeFinder(time1);
                    TimeFinder(time2);
                }
            }
            void TimeFinder(double time)
            {
                int hrhand = (int)(time);
                double dmin = ((time - hrhand) * 60);
                int minhand = (int)(dmin);
                double dsec = ((dmin - minhand) * 60);
                int sec = (int)dsec;
                Console.Write("Hr=" + " " + hrhand + " ");
                Console.Write(minhand + " ");
                Console.WriteLine(sec);
                TimeZone localzone = TimeZone.CurrentTimeZone;
                String s = (localzone.StandardName).ToString();
                DateTime date = new DateTime(2017, 7, 7, hrhand, minhand, sec);
                DateTime dateutc = new DateTime();
                dateutc = TimeZoneInfo.ConvertTimeToUtc(date);
                string easternZoneId = "Eastern Standard Time";
                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById(easternZoneId);
                DateTime targetTime = TimeZoneInfo.ConvertTime(dateutc, easternZone);
                Console.WriteLine("Converted {0} {1} to {2}.", dateutc,
                                  dateutc.Kind, targetTime);
            }

            Console.ReadLine();

        }
    }
}
