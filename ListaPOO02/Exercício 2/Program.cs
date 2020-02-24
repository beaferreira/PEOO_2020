using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores inteiros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int media = (a + b + c + d) / 4;
            Console.WriteLine($"media = {media}");
            
            Console.WriteLine("Números menores que média: ");
            if (a < media) Console.WriteLine($"{a}");
            if (b < media) Console.WriteLine($"{b}");
            if (c < media) Console.WriteLine($"{c}");
            if (d < media) Console.WriteLine($"{d}");

            Console.WriteLine($"Números maiores ou iguais à média: ");
            if (a >= media) Console.WriteLine($"{a}");
            if (b >= media) Console.WriteLine($"{b}");
            if (c >= media) Console.WriteLine($"{c}");
            if (d >= media) Console.WriteLine($"{d}");
            Console.ReadKey();

        }
    }
}
