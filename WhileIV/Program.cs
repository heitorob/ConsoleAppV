using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor da anuidade: ");
            double anu = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor da matrícula: ");
            double matri = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do material: ");
            double mater = double.Parse(Console.ReadLine());

            double mensal = anu / 12;
            int numero = 1;

            Console.WriteLine("\nValor da " + numero + "ª mensalidade: " + (mensal + matri + mater).ToString("C"));

            while (numero < 13)
            {
                numero++;
                Console.WriteLine("Valor da " + numero + "ª mensalidade: " + mensal.ToString("C"));
            }

            Console.ReadKey();
        }
    }
}
