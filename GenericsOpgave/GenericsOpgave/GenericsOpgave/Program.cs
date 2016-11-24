using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsOpgave
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //List<string> MyList = new List<string>();

            //MyList.Add("Linje 1");
            //MyList.Add("Linje 2");
            //MyList.Add("Linje 3");
            //MyList.Add("Linje 4");

            //Console.WriteLine(MyList[0]);
            //Console.WriteLine(MyList[1]);
            //Console.WriteLine(MyList[2]);
            //Console.WriteLine(MyList[3]);

            //Console.WriteLine();

            //Swap<string>(MyList);

            //Console.WriteLine(MyList[0]);
            //Console.WriteLine(MyList[1]);
            //Console.WriteLine(MyList[2]);
            //Console.WriteLine(MyList[3]);

            var a = new List<string>();
            a.Add("A");
            a.Add("B");
            a.Add("C");
            a.Add("D");

            foreach (var s in a)
            {
                Console.WriteLine(s);
            }

            var b = new List<int>();
            b.Add(1);
            b.Add(2);
            b.Add(3);
            b.Add(4);

            foreach (var s in b)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }

        private static void Swap<T>(List<T> myList)
        {
            myList.Reverse();
        }
    }
}
