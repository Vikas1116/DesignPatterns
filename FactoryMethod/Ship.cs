using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    class Ship : ITransport
    {
        public void deliver()
        {
            Console.WriteLine("Truck");
        }
    }
}
