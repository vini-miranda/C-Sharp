using System;

namespace _05_GetAndSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            ContaCorrente conta = new ContaCorrente();
            cliente.Nome = "Vinicius Miranda";
            cliente.Cpf = "123456789-00";
            cliente.Profissao = "Programador";

            conta.Saldo = -10;

            Console.WriteLine(cliente.Nome + " " + cliente.Cpf + " " + cliente.Profissao);
            Console.WriteLine(conta.Saldo);
        }
    }
}
