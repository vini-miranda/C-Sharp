using ByteBank.Funcionario;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionarios carlos = new Funcionarios();
            carlos.Nome = "Carlos";
            carlos.Cpf = "123456789-00";
            carlos.Salario = 2000.75;
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.Cpf = "123456789-00";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);

            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("Bonificação de fim de ano: R$" + carlos.getBonificacao());

            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine("Bonificação de fim de ano: R$" + roberta.getBonificacao());
            Console.WriteLine("Total de bonificação: R$" + gerenciador.getBonificacao());
        }
    }
}
