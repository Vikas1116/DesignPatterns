using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //concrete products - set of distinct but related products
    internal class VictorianChair : IChair
    {
        public void sit()
        {
            Console.WriteLine("VictorianChair");
        }
    }
}
