using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(123, 0);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Erro no parâmetro: " + e.ParamName);
                Console.WriteLine(e.Message);
            }
  
            try
            {
                Metodo();
            }
            catch (Exception erro)
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
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Não é possível dividir " + numero + " por " + divisor);
                throw;
            }
            
        }


    }
}
