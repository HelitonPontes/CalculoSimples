using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valortotal;


            string[] texto = Console.ReadLine().Split(' ');
            int Peca1 = int.Parse(texto[0]), Qtd1 = int.Parse(texto[1]); double Valor1 = double.Parse(texto[2]);
            string[] texto1 = Console.ReadLine().Split(' ');
            int Peca2 = int.Parse(texto1[0]), Qtd2 = int.Parse(texto1[1]); double Valor2 = double.Parse(texto1[2]);

            //int Peca1 = int.Parse(Console.ReadLine()); int Qtd1 = int.Parse(Console.ReadLine()); double Valor1 = double.Parse(Console.ReadLine());


            //int Peca2 = int.Parse(Console.ReadLine()); int Qtd2 = int.Parse(Console.ReadLine()); double Valor2 = double.Parse(Console.ReadLine());


            Valortotal = (Qtd1 * Valor1) + (Qtd2 * Valor2);


            Console.WriteLine("VALOR A PAGAR: R$ " + Valortotal.ToString("#0.00"));

            Console.ReadKey();
        }
    }
}
