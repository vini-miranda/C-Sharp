using ByteBank.Funcionario;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionarios carlos = new Funcionarios("123456789-00");
            carlos.Nome = "Carlos";
            carlos.Salario = 2000.75;
            gerenciador.Registrar(carlos);
            Console.WriteLine("Funcionarios registrados: " + Funcionarios.ContaFuncionarios);

            Diretor roberta = new Diretor("987654321-00");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);
            Console.WriteLine("Funcionarios registrados: " + Funcionarios.ContaFuncionarios);

            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("Bonificação de fim de ano: R$" + carlos.getBonificacao());

            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine(roberta.Cpf);
            Console.WriteLine("Bonificação de fim de ano: R$" + roberta.getBonificacao());
            Console.WriteLine("Total de bonificação: R$" + gerenciador.getBonificacao());
        }
    }
}
