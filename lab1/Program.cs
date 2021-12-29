using System;
using System.Diagnostics;

namespace Praktika1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();
            int n = 300;
            int[] key = new int[3000];
            var rnd = new Random();

            for (int i = 0; i < 3000; i++)
            {
                key[i] = rnd.Next(0, 999);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int z = n - 300; z < n; z++)
                {
                    myStack.Push(key[z]);
                }
                Stopwatch sw = new Stopwatch();
                myStack.N_op = 0;
                sw.Start();
                myStack.Sort();
                sw.Stop();
                Console.WriteLine($"Номер сортировки: {i + 1}  Колличество отсортированных элементов: {n}  Время сортировки (ms): {sw.ElapsedMilliseconds}  Колличество операций (N_op): {myStack.N_op}");
                n += 300;
            }

            Console.ReadLine();

        }
    }
}

