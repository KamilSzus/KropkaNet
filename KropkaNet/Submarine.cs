using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Submarine : IDive, IAccelerate
    {
        static int subnarineId = 0;
        private int m_accelerate;
        private int m_dive;
        private String name;

        public Submarine()
        {
            subnarineId++;
            name = "Submarine " + subnarineId;
        }
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

        public int Dive
        {
            get
            {
                return m_dive;
            }
            set
            {
                if (value >= 0)
                {
                    m_dive = value;
                }
            }
        }
        public override string ToString()
        {
            return name;
        }
    }
}
