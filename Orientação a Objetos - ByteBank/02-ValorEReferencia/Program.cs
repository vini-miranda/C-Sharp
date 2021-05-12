using System;

namespace _02_ValorEReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            ContaCorrente conta2 = new ContaCorrente();
            conta1.saldo = 200;
            conta1.saldo += 100;
            conta2.saldo = 50;

            Console.WriteLine("A conta 1 possui: R$" + conta1.saldo);
            Console.WriteLine("A conta 2 possui: R$" + conta2.saldo);


        }
    }
}
