using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int dobro;

            double n2;
            double raizQuadrada;

            Console.Write("Digite um número inteiro qualquer: ");
            n1 = int.Parse(Console.ReadLine());

            dobro = n1 * 2;

            Console.Write("O dobro de ");
            Console.Write(n1);
            Console.Write(" é ");
            Console.WriteLine(dobro);

            Console.WriteLine("O dobro de {0} é {1}", n1, dobro);

            Console.Write("Digite um número qualquer: ");
            n2 = double.Parse(Console.ReadLine());

            raizQuadrada = Math.Sqrt(n2);

            Console.WriteLine("A raiz quadrada de {0} é {1}", n2, raizQuadrada);

            Console.WriteLine("2 elevado à 4 é {0}", Math.Pow(2,4));

        }
    }
}
