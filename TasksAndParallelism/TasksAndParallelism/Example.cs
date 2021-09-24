using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksAndParallelism
{
   public class Example
    {
        public void Threading()
        {
            long totalSize = 0;
            if (!Directory.Exists(@"C:\Training\Batch2Assignment\Batch2Assignment"))
            {
                Console.WriteLine("The directory does not exist.");
                return; 
            }
            String[] files = Directory.GetFiles(@"C:\Training\Batch2Assignment\Batch2Assignment"); 
            
            Parallel.For(0, files.Length, index => 
            { 
                FileInfo fi = new FileInfo(files[index]); 
                long size = fi.Length; 
                Interlocked.Add(ref totalSize, size); 
            }); 
            Console.WriteLine("Directory '{0}':", @"C:\Training\Batch2Assignment\Batch2Assignment"); 
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        }


        public void Display()
        {
            FileStream fs = new FileStream(@"C:\Training\Training-Day-7\TasksAndParallelism\TasksAndParallelism\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            List<string> line = new List<string>();
            line = File.ReadLines(@"C:\Training\Training-Day-7\TasksAndParallelism\TasksAndParallelism\networklog.txt").ToList();
            Parallel.For(0, line.Count, i => 
            {
                Console.WriteLine("Line = {0} , Thread = {1}", line[i], Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(500);
            });

        }

        
    }

    

}
