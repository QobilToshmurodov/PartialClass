﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Employee employee = new Employee();
           employee.Speak();
            employee.Work();
        }
    }
}