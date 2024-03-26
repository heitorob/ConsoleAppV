using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número e retornaremos a tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            int cont = numero;

            while (cont < 100)
            {
                Console.WriteLine(cont);
                cont += numero;
            }

                Console.ReadKey();

        }
    }
}
