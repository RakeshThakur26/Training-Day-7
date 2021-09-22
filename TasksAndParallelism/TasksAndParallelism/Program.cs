using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksAndParallelism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sequential Thread...");
            for (int i = 1; i < n; i++)
            {
                if(i%2 == 0)
                    Console.WriteLine("Even number : "+ i + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
                else
                    Console.WriteLine("Odd number  : " + i + ", Thread : " + Thread.CurrentThread.ManagedThreadId);

                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine("Parallel Thread...");

            Parallel.For(1, n,i =>
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even number : " + i + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
                else
                    Console.WriteLine("Odd number  : " + i + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(500);
            });

            Console.ReadLine();
          
        }
      
    }
}
