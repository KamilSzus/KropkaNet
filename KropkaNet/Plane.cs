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
            if (m_accelerate > 0)
            {
                m_accelerate--;
            }
        }

        public void decRise()
        {
            if (m_rise > 0)
            {
                m_rise--;
            }
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
