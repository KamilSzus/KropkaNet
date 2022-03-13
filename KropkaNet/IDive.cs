using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    interface IDive
    {
        void incDive();
        void decDive();
        int m_dive { get; set; }
    }
}
