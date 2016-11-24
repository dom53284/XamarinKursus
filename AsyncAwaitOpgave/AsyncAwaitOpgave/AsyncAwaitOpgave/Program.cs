using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitOpgave
{
    class Program
    {
        public async static Task MainAsync()
        {
            await Task.Delay(1000);
        }

        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

    }
}
