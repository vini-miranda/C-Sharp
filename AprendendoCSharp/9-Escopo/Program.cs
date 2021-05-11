using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 9 - Escopo");

            int idade = 16;
            bool acompanhado = false;
            string mensagem;

            if (acompanhado==true)
            {
                mensagem = "Sim.";
            }
            else
            {
                mensagem = "Não.";
            }

            Console.WriteLine("Sua idade: " + idade);
            Console.WriteLine("Acompanhado? " + mensagem);

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
