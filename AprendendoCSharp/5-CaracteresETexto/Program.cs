using System;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 5 - Caracteres e Texto");

            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 65);
            Console.WriteLine(valor);

            string palavra = "Alura cursos de tecnologia ";
            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            Console.WriteLine("O programa finalizou. tecle ENTER para encerrar...");
            Console.ReadLine();

        }
    }
}
