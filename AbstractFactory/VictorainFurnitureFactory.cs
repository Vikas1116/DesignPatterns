using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //concrete factory
    internal class VictorainFurnitureFactory : FurnitureFactory
    {
        public IChair createChair()
        {
            return new VictorianChair();
        }
        public ISofa createSofa()
        {
            return new VictorianSofa();
        }
    }
}