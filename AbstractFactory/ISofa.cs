using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //abstract products - set of distinct but related products
    internal interface ISofa
    {
        public void sit()
        {
            Console.WriteLine("sofa");
        }
    }
}
