﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    class Truck : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Truck");
        }
    }
}