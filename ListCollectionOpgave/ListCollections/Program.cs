using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;
            List<int> evenNumbers = new List<int>();
            ArrayList old = new ArrayList();
            Dictionary<int, bool> isEvenNumberDict = new Dictionary<int, bool>();

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                    old.Add(i);
                    isEvenNumberDict.Add(i, true);
                }
                else
                {
                    isEvenNumberDict.Add(i, false);
                }

            }

            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            

            //foreach (int entry in isEvenNumberDict)
            //{
            //    Console.WriteLine(entry.Key + "" + entry.)
            //}





            Console.ReadKey();
        }
    }
}
