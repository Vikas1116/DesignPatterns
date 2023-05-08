using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernSofa : ISofa
    {
        public void sit()
        {
            Console.WriteLine("ModernSofa");
        }
    }
