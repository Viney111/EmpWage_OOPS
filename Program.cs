﻿using System;
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
            CompEmpWage e1 = new CompEmpWage();
            e1.ComputeWage(100, 20, 20, "TATA");
            e1.ComputeWage(110, 30, 25, "MARUTI");

        }
    }
}
