using System;

namespace _2_Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 2 - Criando Variáveis");

            int idade = 22;
            Console.WriteLine(idade);

            idade = 22 + 15;
            Console.WriteLine(idade);

            idade = (22 / 2) * 5;
            Console.WriteLine(idade);

            idade = 52 - 30;
            Console.WriteLine("Sua idade é " + idade + " anos.");

            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
