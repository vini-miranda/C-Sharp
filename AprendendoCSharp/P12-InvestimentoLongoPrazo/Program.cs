using System;

namespace P12_InvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 12 - Investimento Longo Prazo");

            double valor = 1000;
            double investimento = 1.0036;

            for(int ano = 1; ano<=5; ano++)
            {
                for(int mes = 1; mes<=12; mes++)
                {
                    valor *= investimento;
                }
                investimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento você terá R$" + valor);
            

            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
