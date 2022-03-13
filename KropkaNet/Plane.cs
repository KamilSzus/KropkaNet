using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Plane : IRise, IAccelerate
    {
        public int m_accelerate { get; set; }
        public int m_rise { get; set; }

        public void decAccelerate()
        {
            m_accelerate--;
        }

        public void decRise()
        {
            m_rise--;
        }

        public void incAccelerate()
        {
            m_accelerate++;
        }

        public void incRise()
        {
            m_rise++;
        }

        public override string ToString()
        {
            return "Plane";
        }
    }
}
