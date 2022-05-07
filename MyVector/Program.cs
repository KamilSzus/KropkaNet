using System;

namespace MyVector
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector<string> vector = new MyVector<string>(2);
            vector[0] = "Hello";
            vector.pushBack("Word\n");
            vector[1]="Word";
            Console.WriteLine(vector[1]);
            vector.dump();
            try
            {
                String v = vector[3];
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine(e.Message);
             }

            Console.ReadKey();
        }
    }
}
