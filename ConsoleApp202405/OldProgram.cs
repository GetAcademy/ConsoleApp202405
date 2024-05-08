using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp202405
{
    internal class OldProgram
    {
        // function Main(args)
        static void Mainx(string[] args)
        {
            Console.WriteLine($"antall argumenter: {args.Length}" );

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            int i = Terje(5);
        }

        static int Terje(int n)
        {
            Console.WriteLine("Terje");
            return n * 2;
        }

    }
}
