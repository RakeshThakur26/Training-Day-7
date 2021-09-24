using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksAndParallelism
{

   public class Program
    {
        public static void EvenNum(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even Number : " + i);
                Thread.Sleep(500);

            }

        }

        public static void OddNum(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine("Odd Number : " + i);
                Thread.Sleep(500);
            }

        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //DateTime start = DateTime.Now;
            //Console.WriteLine("Current date and time : " + start.ToString());

            //Console.WriteLine("Sequential Thread...");
            //for (int index = 1; index <= n; index++)
            //{
            //    if (index % 2 == 0)
            //        Console.WriteLine("Even number : " + index + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
            //    else
            //        Console.WriteLine("Odd number  : " + index + ", Thread : " + Thread.CurrentThread.ManagedThreadId);

            //    Thread.Sleep(500);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Parallel Thread...");

            //Parallel.For(1, n, index =>
            // {
            //     if (index % 2 == 0)
            //         Console.WriteLine("Even number : " + index + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
            //     else
            //         Console.WriteLine("Odd number  : " + index + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
            //     Thread.Sleep(500);
            // });

            //Console.WriteLine("\nCurrent Time : " + DateTime.Now.ToLongTimeString());
            //DateTime end = DateTime.Now;

            //TimeSpan timespan = end - start;
            //Console.WriteLine("Total time taken : " + timespan.TotalSeconds);


            Example example = new Example();
            //example.Threading();

            // example.Display();

            Example exp = new Example();
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Main thread started : ");
            Console.WriteLine("Multi thread started... ");
            Thread EvenNumb = new Thread(() => Program.EvenNum(n));
            Thread OddNumb = new Thread(() => Program.OddNum(n));

            EvenNumb.Start();
            OddNumb.Start();
            Console.WriteLine("Multi thread Finished : ");

            Console.WriteLine("Asyn Method started...");
            Task EvenTask = new Task(() => Program.EvenNum(n));
            Task OddTask = new Task(() => Program.OddNum(n));

            EvenTask.Start();
            OddTask.Start();
            Console.WriteLine("Asyn Method started...");
            Console.ReadLine();
          
        }
      
    }
}
