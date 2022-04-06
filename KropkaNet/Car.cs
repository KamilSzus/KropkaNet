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
        private int m_accelerate;
        private String name;

        public Car()
        {
            carId++;
            name = "Car " + carId;
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

        public override string ToString()
        {
            return name;
        }
    }
}
