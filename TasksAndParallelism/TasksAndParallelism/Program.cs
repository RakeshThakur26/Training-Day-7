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
           
            DateTime start = DateTime.Now;
            Console.WriteLine("Current date and time : " + start.ToString());

            Console.WriteLine("Sequential Thread...");
            for (int index = 1; index <= n; index++)
            {
                if (index % 2 == 0)
                    Console.WriteLine("Even number : " + index + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
                else
                    Console.WriteLine("Odd number  : " + index + ", Thread : " + Thread.CurrentThread.ManagedThreadId);

                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine("Parallel Thread...");

            Parallel.For(1, n, index =>
             {
                 if (index % 2 == 0)
                     Console.WriteLine("Even number : " + index + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
                 else
                     Console.WriteLine("Odd number  : " + index + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
                 Thread.Sleep(500);
             });

            Console.WriteLine("\nCurrent Time : " + DateTime.Now.ToLongTimeString());
            DateTime end = DateTime.Now;

            TimeSpan timespan = end - start;
            Console.WriteLine("Total time taken : " + timespan.TotalSeconds);


            //Example example = new Example();
            //example.Threading();
            Console.ReadLine();
          
        }
      
    }
}
