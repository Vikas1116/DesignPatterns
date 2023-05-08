using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernChair : IChair
    {
        public void sit()
        {
            Console.WriteLine("ModernChair");
        }
    }
}
