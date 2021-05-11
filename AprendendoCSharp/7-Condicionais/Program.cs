using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 7 - Condicionais");

            int idade = 22;
            int qtdePessoas = 1;
            Console.WriteLine("Sua idade: " + idade);

            if (idade > 18)
            {
                Console.WriteLine("Você é maior de idade. Seja bem Vindo!");
            }
            else
            {
                if (qtdePessoas >= 2)
                {
                    Console.WriteLine("Você é menor de idade, mas pode entrar pois está acompanhado");

                }
                else
                {
                    Console.WriteLine("Você é menor de idade e sua entrada não é permitida.");
                }
                
            }

            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
