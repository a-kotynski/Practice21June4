using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice21June4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Speed limit: ");
            double speedLimit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Car's speed: ");
            double carSpeed = Convert.ToDouble(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("ok");
            }
            else if (carSpeed > speedLimit)
            {
                Demerit(speedLimit, carSpeed); //kolejność w argumencie ma znaczenie
            }
            else
            {
                Console.WriteLine("hmm?");
            }

        }
        /*
        public static void Demerit(double speedLimit, double carSpeed)
        {
            double demeritCount = (carSpeed - speedLimit)/5;
            if (demeritCount < 12)
            {
                Console.WriteLine("Your demerit count: {0}", demeritCount);
            }
            else if (demeritCount >= 12)
            {
                Console.WriteLine("Licence suspended.");
            }
        }
        */
        public static void Demerit(double speedLimitOne, double carSpeedOne) // nazwy zadeklarowanych zmiennych nie muszą być takie same jak te w funkcji Main()
        {
            double demeritCount = (carSpeedOne - speedLimitOne) / 5;
            if (demeritCount < 12)
            {
                Console.WriteLine("Your demerit count: {0}", demeritCount);
            }
            else if (demeritCount >= 12)
            {
                Console.WriteLine("Licence suspended.");
            }
        }
    }
}