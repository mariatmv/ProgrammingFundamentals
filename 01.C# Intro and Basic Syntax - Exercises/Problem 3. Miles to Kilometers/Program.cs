﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            var toKil = miles * 1.60934;
            Console.WriteLine("{0:f2}", toKil);
        }
    }
}
