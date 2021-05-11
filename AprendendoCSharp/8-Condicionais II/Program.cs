using System;

namespace _8_Condicionais_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 8 - Condicionais II");

            int idade = 16;
            bool acompanhado = true;
            Console.WriteLine("Sua idade: " + idade);
            Console.WriteLine("Acompanhado?: " + acompanhado);

            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");

            }

            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
