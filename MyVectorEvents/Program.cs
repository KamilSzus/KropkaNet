using System;

namespace MyVector
{
    class Program
    {
        static void PrintSize(int size)
        {
            Console.WriteLine("Size = {0}", size);
        }

        static void PrintCapacity(int size)
        {
            Console.WriteLine("Capacity = {0}", size);
        }

        static void Main(string[] args)
        {
            MyVector<string> vector = new MyVector<string>(2);
            vector.eventHandler += PrintSize;
            vector.eventHandler1 += PrintCapacity;
            vector[0] = "Hello";
            vector[1] = "Word";
            vector[2] = "ALA";
            vector[3] = "KOT";
            Console.WriteLine(vector[1]);
            vector.dump();
            try
            {
                String v = vector[3];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
