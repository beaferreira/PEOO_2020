using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dgite quatro valores inteiros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int sp = 0;
            int si = 0;

            if (a % 2 == 0) sp = sp + a;
            if (b % 2 == 0) sp = sp + b;
            if (c % 2 == 0) sp = sp + c;
            if (c % 2 == 0) sp = sp + d;

            if (a % 2 == 1) si = si + a;
            if (b % 2 == 1) si = si + b;
            if (c % 2 == 1) si = si + c;
            if (c % 2 == 1) si = si + d;

            Console.WriteLine($"Soma dos pares = {sp}");
            Console.WriteLine($"Soma dos ímpares = {si}");

            Console.ReadKey();



        }
    }
}
