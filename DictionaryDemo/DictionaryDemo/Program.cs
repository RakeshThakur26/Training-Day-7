using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Payer 5");
            d.Add(2, "Payer 1");
            d.Add(3, "Payer 3");
            d.Add(4, "Payer 2");
            d.Add(5, "Payer 4");

            Console.WriteLine("Number of players : " + d.Count);

            string temp = d[1];
            string temp2 = d[5];

            d.Remove(1);
            d.Add(1, temp2);
            d.Remove(5);
            d.Add(5, temp);

            //d.Add(1,temp2);
            //d.Add(5, temp);

            foreach (var item in d)
            {
                Console.WriteLine("Key : " + item.Key + ", Value : " + item.Value);
            }

            Console.WriteLine("Winner is : " + d[1]);

            Console.WriteLine("Clearing all the data of Dictionary..!");
            d.Clear();
                    

            Console.ReadLine();

        }
    }
}
