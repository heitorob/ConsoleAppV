using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WhileIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número a ser multiplicado: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Insira o número de multiplicações: ");
            int multi = int.Parse(Console.ReadLine());
            int resu = numero;
            int cont = 1;

            while (multi > 0)
            {
                Console.WriteLine(numero + " x " + cont + " = " + resu);
                resu += numero;
                cont++;
                multi--;
            }
            Console.ReadKey();
        }
    }
}
