using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Exceção tratada.");
            }
            
            
        }

        static void Metodo()
        {
           
                TestaDivisao(0);    
        }

        static void TestaDivisao(int divisor)
        {
                Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }


    }
}
