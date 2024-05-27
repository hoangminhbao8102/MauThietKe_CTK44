using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.GangOfFour.Adapter.Structural
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called target Request()");
        }
    }
}
