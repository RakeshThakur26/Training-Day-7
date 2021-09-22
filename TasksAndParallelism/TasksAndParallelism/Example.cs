using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksAndParallelism
{
    class Example
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
    }
}
