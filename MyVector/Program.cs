using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector<int> vector = new MyVector<int>(5);
            int cappacity=vector.m_cappacity;
        }
    }
}
