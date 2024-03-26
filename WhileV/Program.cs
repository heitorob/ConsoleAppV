using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            double folha = 0;
            int funcionarios = 0;

            while (resp == "s")
            {
                Console.WriteLine("Insira a categoria do funcionário");
                Console.Write("(A - Assalariado . C - Comissionado . H - Horista): ");
                string categoria = Console.ReadLine().ToLower();

                switch (categoria)
                {
                    case "a":
                        Console.Write("Insira o salário do funcionário: ");
                        double bruto = double.Parse(Console.ReadLine());

                        Console.Write("Insira o desconto do salário: ");
                        double desconto = double.Parse(Console.ReadLine());

                        double salarioa = bruto - desconto;
                        folha += salarioa;
                        funcionarios++;

                        Console.WriteLine("Salário líquido do funcionário: " + salarioa.ToString("C"));

                        break;

                    case "c":
                        Console.Write("Insira o valor das vendas: ");
                        double vendas = double.Parse(Console.ReadLine());

                        Console.Write("Insira a porcentagem da comissão: ");
                        double comissao = double.Parse(Console.ReadLine());

                        double salarioc = vendas * (comissao / 100);
                        folha += salarioc;
                        funcionarios++;

                        Console.WriteLine("Salário líquido do funcionário: " + salarioc.ToString("C"));

                        break;

                    case "h":
                        Console.Write("Insira o número de horas trabalhadas: ");
                        int horas = int.Parse(Console.ReadLine());

                        Console.Write("Insira o valor da hora: ");
                        double vlrhora = double.Parse(Console.ReadLine());

                        double salarioh = horas * vlrhora;
                        folha += salarioh;
                        funcionarios++;

                        Console.WriteLine("Salário líquido do funcionário: " + salarioh.ToString("C"));

                        break;

                    default:
                        Console.WriteLine("CÓDIGO INCORRETO!! TENTE NOVAMENTE!!");
                        break;
                }
                Console.WriteLine("\nDeseja cadastrar outro funcionário?");
                Console.Write("S - SIM . N - NÃO : ");
                resp = Console.ReadLine().ToLower();
                Console.Clear();
            }

            Console.WriteLine("Número de funcionários cadastrados: " + funcionarios);
            Console.WriteLine("Folha de pagamento: " + folha.ToString("C"));
            Console.WriteLine("Média salarial da empresa: " + (folha / funcionarios).ToString("C"));

            Console.ReadKey();
        }
    }
}
