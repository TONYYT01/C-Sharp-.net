using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Program
    {
        static void Main(string[] args  )
        {
            Random random = new Random();
            int a = random.Next(0, 9);
            int b = random.Next(0, 9);
            int c = random.Next(0, 9);
            Console.WriteLine(a+" "+b+" "+c);
            Console.ReadKey();
        }
    }
}
