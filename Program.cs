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
            //Making Object of CompEmpWage to call Different Companies ComputeWage method.
            EmpWageBuilderArray empArray = new EmpWageBuilderArray(2);
            empArray.AddEmpWageInArray(100, 20, 18, "TATA");
            empArray.AddEmpWageInArray(120, 25, 20, "MARUTI");
            empArray.GetEmpWage();

            
            
        }
    }
}
