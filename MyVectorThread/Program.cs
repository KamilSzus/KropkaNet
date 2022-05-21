using System;
using System.Diagnostics;

namespace MyVector
{
    class Program
    {
        private static MyVector<int> safeThreadMyVector = new MyVector<int>(0);
        readonly private static int threadNumber = 64;
        static void PrintSize(int size)
        {
            Console.WriteLine("Size = {0}", size);
        }

        static void PrintCapacity(int size)
        {
            Console.WriteLine("Capacity = {0}", size);
        }

        static private void BlockingAdd()
        {
            Stopwatch sw = new Stopwatch();
            int threadId = Thread.CurrentThread.ManagedThreadId;

            sw.Start();
            safeThreadMyVector.pushBackBlocking(threadId);
            sw.Stop();

            Console.WriteLine($"Czas oczekiwania {threadId}: {sw.Elapsed}");
        }

        static private void NonblockingAdd()
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;

            bool isAdded = safeThreadMyVector.pushBackNonBlocking(threadId);

            Console.WriteLine(isAdded ? $"Dodano id dla wątku {threadId}" : $"Niedodano id dla wątku {threadId}");
        }

        static void Main(string[] args)
        {

            Thread[] threads = new Thread[threadNumber];
            Random random = new Random();
//            safeThreadMyVector.eventHandler += PrintSize;
//            safeThreadMyVector.eventHandler1 += PrintCapacity;

            for (int i = 0; i < threadNumber; i++)
            {
                if (i % 2 == 0)
                {
                    var thread = new Thread(BlockingAdd);
                    threads[i] = thread;
                    thread.Start();
                }
                else
                {
                    var thread = new Thread(NonblockingAdd);
                    threads[i] = thread;
                    thread.Start();
                }
            }

            for (int i = 0; i < threadNumber; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine("Success");

            safeThreadMyVector.saveToFile("array.txt");

            Console.ReadKey();
        }
    }
}
