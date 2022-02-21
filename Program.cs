using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmpWage by OOPS Program");
            //CONSTATNTS
            const int ISPRESENT = 1;
            const int ISABSENT = 0;
            //VARIABLES
            int empCheck;

            Random random = new Random();
            empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case ISPRESENT:
                    Console.WriteLine("Employee is present");
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }

        }
    }
}
