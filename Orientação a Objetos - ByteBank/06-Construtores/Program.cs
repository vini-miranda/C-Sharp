using System;

namespace _06_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalContas);
            ContaCorrente conta = new ContaCorrente(456,123456);

            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Conta);
            Console.WriteLine("Saldo: R$" + conta.Saldo);

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalContas);

            ContaCorrente conta2 = new ContaCorrente(123,654321);
            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalContas);           
        }
    }
}
