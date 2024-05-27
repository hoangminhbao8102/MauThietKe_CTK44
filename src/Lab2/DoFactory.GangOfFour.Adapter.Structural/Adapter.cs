using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.GangOfFour.Adapter.Structural
{
    class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();
        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
