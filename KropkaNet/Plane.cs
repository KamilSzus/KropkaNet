using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Plane : IRise, IAccelerate
    {
        static int planId = 0;
        private int m_accelerate;
        private int m_rise;
        public int Accelerate
        {
            get
            {
                return m_accelerate;
            }
            set
            {
                if (value >= 0)
                {
                    m_accelerate = value;
                }
            }
        }
        public int Rise
        {
            get
            {
                return m_rise;
            }
            set
            {
                if (value >= 0)
                {
                    m_rise = value;
                }
            }
        }

        public Plane()
        {
            planId++;
        }

        public override string ToString()
        {
            return "Plane "+planId;
        }
    }
}
