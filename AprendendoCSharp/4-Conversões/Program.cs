using System;

namespace _4_Conversões
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 4 - Casting e outras variáveis");

            //DOUBLE
            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine("Salário: " + valor);

            double valor1 = 0.1;
            double valor2 = 0.2;
            double total = valor1 + valor2;
            Console.WriteLine("Soma: " + total);

            //LONG - 64BITS
            long habitantes = 15000000;
            Console.WriteLine("Habitantes: " + habitantes);

            //SHORT - 16BITS
            short estoque = 150;
            Console.WriteLine("Estoque: " + estoque);

            //FLOAT
            float altura = 1.74f;
            Console.WriteLine("Altura: " + altura);

            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
