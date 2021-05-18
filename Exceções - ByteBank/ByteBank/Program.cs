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
                ContaCorrente conta2 = new ContaCorrente(321, 987654);

                Console.WriteLine("Saldo atual: R$" + conta.Saldo);
                conta.Depositar(500);
                Console.WriteLine("Saldo atual: R$" + conta.Saldo);
                

                conta.Transferir(700, conta2);
                Console.WriteLine("Saldo atual: R$" + conta.Saldo);
                Console.WriteLine("Saldo atual: R$" + conta2.Saldo);


            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Erro no parâmetro: " + e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);

                Console.WriteLine("\n\nINFORMAÇÕES DA INNER EXCEPTION");

                Console.WriteLine(e.InnerException.StackTrace);
                Console.WriteLine(e.InnerException.Message);
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
