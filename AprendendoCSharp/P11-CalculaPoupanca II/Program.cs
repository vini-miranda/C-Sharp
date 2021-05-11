using System;

namespace P11_CalculaPoupanca_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 11 - Calcula poupança II");

            double valor = 1000;

            for(int mes = 1; mes<=12; mes++)
            {
                valor *= 1.0036;
                Console.WriteLine("Após " + mes + " meses, você terá: R$" + valor);
            }

            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
