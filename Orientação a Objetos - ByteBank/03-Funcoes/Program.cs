using System;

namespace _03_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            ContaCorrente conta2 = new ContaCorrente();

            Console.WriteLine("Saldo atual: R$" + conta.saldo);

            string msg = conta.Sacar(50);
            Console.WriteLine(msg);
            Console.WriteLine("Saldo atual: R$" + conta.saldo);

            string msg2 = conta.Sacar(100);
            Console.WriteLine(msg2);
            Console.WriteLine("Saldo atual: R$" + conta.saldo);

            conta.Depositar(800);
            Console.WriteLine("Saldo atual: R$" + conta.saldo);

            conta.Transferir(400, conta2);
            Console.WriteLine();
            Console.WriteLine("Saldo atual conta1: R$" + conta.saldo);
            Console.WriteLine("Saldo atual conta2: R$" + conta2.saldo);

            conta2.Transferir(50, conta);
            Console.WriteLine();
            Console.WriteLine("Saldo atual conta1: R$" + conta.saldo);
            Console.WriteLine("Saldo atual conta2: R$" + conta2.saldo);





        }
    }
}
