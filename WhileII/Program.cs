using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 0 para pares ou 1 para ímpares: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Clear();

            while (numero < 20)
            {
                Console.WriteLine(numero);
                numero += 2;
            }

            Console.ReadKey();
        }
    }
}
