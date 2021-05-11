using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 13 - For Encadeado");
            Console.WriteLine();
            for (int linha = 0; linha<=10; linha++)
            {
                for(int coluna = 0; coluna<=10; coluna++)
                {
                    Console.Write("*");
                    if (coluna >= linha)
                    {
                        break;
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
