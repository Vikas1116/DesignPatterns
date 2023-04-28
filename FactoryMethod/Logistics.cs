using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    //abstract class
    //factory method that will make object construction
    abstract class Logistics
    {
        public abstract Transport createTransport();
    }
}
