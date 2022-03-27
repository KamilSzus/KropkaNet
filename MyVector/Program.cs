using System;

namespace MyVector
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector<string> vector = new MyVector<string>(2);
            vector[0] = "Hello";
            Console.WriteLine(vector[0]);
            vector.pushBack("Word");
            Console.WriteLine(vector[1]);
            vector[1]="Hello";
            Console.WriteLine(vector[1]);
            for(int i = 0; i < vector.m_size-1; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
    }
}
