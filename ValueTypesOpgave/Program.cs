using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumber x = new MyNumber();
            x.value = 3;

            AddTo(x, 1);

            Console.WriteLine("AddTo MyNumber(3), 1 = " + x);
            Console.ReadKey();

        }

        static void AddTo(MyNumber x, int y)
        {
            x.value += y;
        }

    }



    public class MyNumber
    {
        public int value;
        public override string ToString()
        {
            return value.ToString();
        }
    }

}
