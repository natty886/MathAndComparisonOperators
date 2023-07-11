using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int RateP1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int HoursP1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int RateP2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int HoursP2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1");
            int SalaryP1 = (RateP1 * HoursP1) * 52;
            Console.WriteLine(SalaryP1);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2");
            int SalaryP2 = (RateP2 * HoursP2) * 52;
            Console.WriteLine(SalaryP2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = SalaryP1 > SalaryP2;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();
            //int total = 5 + 10;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine();

            //int difference = 10-5:
            //Console.WriteLine("five minus Ten = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            ////bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();


        }
    }
}
