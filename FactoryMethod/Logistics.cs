using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    //abstract class
    //factory method that will make object construction
    //creator - maybe main creator
    abstract class Logistics
    {
        public abstract ITransport createTransport();
    }
}
