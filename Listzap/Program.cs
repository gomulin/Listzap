using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listzap
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            List<int> list = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                list.Add(r.Next(0, 101));
            }

            list.Sort();
            int newItem = r.Next(0, 101);
            int index = list.BinarySearch(newItem);
            if (index < 0)
                index = ~index;

            list.Insert(index, newItem);

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
        }
    }
}
