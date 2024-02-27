using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anonasc, idade;
            Console.WriteLine("Digite o ano que você nasceu:");
            anonasc = int.Parse(Console.ReadLine());
            idade = 2024 - anonasc;
            if (idade >= 16 && idade >= 18)
            {
                Console.WriteLine("Você já tem idade para votar e para conseguir a C.N.H.");
            }
            else if (idade >= 16)
            {
                Console.WriteLine("Você já tem idade para votar.");
            }
            Console.ReadKey();
        }
    }
}
