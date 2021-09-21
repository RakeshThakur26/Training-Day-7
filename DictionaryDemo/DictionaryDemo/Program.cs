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
            Dictionary<int, string> d = new Dictionary<int, string>() {
                {1, "Player 5"} , {2, "Player 1"},{3, "Player 3"},{4, "Player 2"},{5, "Player 4"}
            };

            //d.Add(1, "Player 5");
            //d.Add(2, "Player 1");
            //d.Add(3, "Player 3");
            //d.Add(4, "Player 2");
            //d.Add(5, "Player 4");

            Console.WriteLine("Number of players : " + d.Count);
            string temp = d[1];          
            d[1] = d[5];
            d[5] = temp;

            foreach (var item in d)
            {
                Console.WriteLine("Key : " + item.Key + ", Value : " + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Winner is : " + d[1]);
            Console.WriteLine("Clearing all the data of Dictionary..!");
            d.Clear();
    
            Console.ReadLine();
        }
    }
}
