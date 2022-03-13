using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    interface IAccelerate
    {
        void incAccelerate();
        void decAccelerate();
        int m_accelerate{ get; set; }
    }
}
