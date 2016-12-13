using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            Console.WriteLine(x);

            Console.WriteLine(x.Times1000());

            Console.WriteLine(8.Times1000());

            Console.ReadKey();

        }
    }

    public static class MyExtensions
    {
        public static int Times1000(this int i)
        {
            return i * 1000;
        }
    }


}
