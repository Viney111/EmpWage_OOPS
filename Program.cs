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
            EmpWageBuilderArrayList empWageBuilderArrayList = new EmpWageBuilderArrayList();
            empWageBuilderArrayList.AddEmpInArrayList(80, 20, 20, "TATA");
            empWageBuilderArrayList.AddEmpInArrayList(70, 20, 20, "MARUTI");
            empWageBuilderArrayList.AddEmpInArrayList(90, 20, 20, "FORD");
            //Calling function to fetch salary by passing company name.
            empWageBuilderArrayList.GetEmpWage("MARUTI");
        }
    }
}
