using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Submarine : IDive, IAccelerate
    {
        public int m_accelerate { get; set; }
        public int m_dive { get; set; }

        public void decAccelerate()
        {
            if (m_accelerate > 0)
            {
                m_accelerate--;
            }
        }

        public void decDive()
        {
            if (m_dive>0)
            {
                m_dive--;
            }
        }

        public void incAccelerate()
        {
            m_accelerate++;
        }

        public void incDive()
        {
            m_dive++;
        }
        public override string ToString()
        {
            return "Submarine";
        }
    }
}
