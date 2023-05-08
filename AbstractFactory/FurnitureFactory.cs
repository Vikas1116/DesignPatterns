using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //abstract factory
    internal interface FurnitureFactory
    {
        public ISofa createSofa();
        public IChair createChair();
    }
}
