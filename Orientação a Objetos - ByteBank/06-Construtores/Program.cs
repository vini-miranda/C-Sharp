using System;

namespace _06_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(456,123456);

            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Conta);
            Console.WriteLine("Saldo: R$" + conta.Saldo);
            
        }
    }
}
