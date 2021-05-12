using System;

namespace _04_NamespacesEClassesConjuntas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente vinicius = new Cliente();
            ContaCorrente conta = new ContaCorrente();

            vinicius.nome = "Vinicius Alves";
            vinicius.cpf = "123.456.789-00";
            vinicius.profissao = "Desenvolvedor C#";

            conta.titular = vinicius;
            conta.agencia = 456;
            conta.conta = 123456;

            vinicius.nome = "Vinicius alves Miranda";

            Console.WriteLine("Nome: " + conta.titular.nome);
            Console.WriteLine("Saldo: R$" + conta.saldo);
            


        }
    }
}
