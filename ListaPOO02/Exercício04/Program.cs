using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro horário no formato hh:mm");
            string[] h1 = Console.ReadLine().Split(':');
            Console.WriteLine("Digite o segundo horário no formato hh:mm");
            string[] h2 = Console.ReadLine().Split(':');

            int min = int.Parse(h1[1]) + int.Parse(h2[1]);
            int horas = (min / 60) + int.Parse(h1[0]) + int.Parse(h2[0]);

            if (min >= 60) min = min % 60;

            Console.WriteLine($"Total de horas = {horas:00}:{min:00}");

            Console.ReadKey();



        }
    }
}
