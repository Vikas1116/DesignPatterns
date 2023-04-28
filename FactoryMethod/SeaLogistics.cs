using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    internal class SeaLogistics : Logistics
    {
        public override Transport createTransport()
        {
            return new Ship();
        }
    }
}
