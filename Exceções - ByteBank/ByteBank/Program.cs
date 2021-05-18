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
                ContaCorrente conta = new ContaCorrente(123, 456654);
                Console.WriteLine("Saldo atual: R$" + conta.Saldo);
                conta.Depositar(100);
                Console.WriteLine("Saldo atual: R$" + conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine("Saldo atual: R$" + conta.Saldo);

            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Erro no parâmetro: " + e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
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

                TestaDivisao(2);    
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
