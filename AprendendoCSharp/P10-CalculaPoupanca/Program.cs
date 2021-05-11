using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 10 - Calcula poupança");

            double valor = 1000;
            int mes = 1;

            while (mes <= 12)
            {
                valor = valor + valor * 0.0036;
                Console.WriteLine("Após " + mes +" meses, você terá: R$" + valor);

                mes++;
            }


            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
