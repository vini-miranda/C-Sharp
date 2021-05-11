using System;

namespace _3_VariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 3 -  Criando Variáveis com ponto flutuante.");

            double salario = 1450.23;
            double idade = 15;
            Console.WriteLine(salario);

            idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 15.0 / 2;
            Console.WriteLine(idade);

            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
