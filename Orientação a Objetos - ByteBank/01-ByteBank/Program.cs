using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.agencia = 356;
            conta.conta = 356741;
            conta.saldo = 100.75;

            Console.WriteLine("Nome: " + conta.titular);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Conta: " + conta.conta);
            Console.WriteLine("Saldo: R$" + conta.saldo);
        }
    }
}
