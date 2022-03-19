using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Computer
    {
        static int computerId = 0;

        public Computer()
        {
            computerId++;
        }
        public override string ToString()
        {
            return "Computer " + computerId;
        }
    }
}
