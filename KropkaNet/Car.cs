using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Car:IAccelerate
    {
        static int carId = 0;

        public Car()
        {
            carId++;
        }
        public int m_accelerate { get; set; }

        public void decAccelerate()
        {
            if (m_accelerate > 0)
            {
                m_accelerate--;
            }
        }

        public void incAccelerate()
        {
            m_accelerate++;
        }
        public override string ToString()
        {
            return "Car "+ carId;
        }
    }
}
