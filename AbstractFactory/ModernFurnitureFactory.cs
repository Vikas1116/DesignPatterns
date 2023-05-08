using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //concrete factory
    internal class ModernFurnitureFactory : FurnitureFactory
    {
        public IChair createChair()
        {
            return new ModernChair();
        }
        public ISofa createSofa()
        {
            return new ModernSofa();
        }
    }
}
