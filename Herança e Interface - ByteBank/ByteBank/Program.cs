using ByteBank.Funcionario;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionarios carlos = new Funcionarios(2000,"123456789-00");
            carlos.Nome = "Carlos";
            carlos.AumentarSalario();
            gerenciador.Registrar(carlos);
            Console.WriteLine("Salário: R$" + carlos.Salario);
            Console.WriteLine("Funcionarios registrados: " + Funcionarios.ContaFuncionarios);

            Diretor roberta = new Diretor(5000,"987654321-00");
            roberta.Nome = "Roberta";
            roberta.AumentarSalario();
            gerenciador.Registrar(roberta);
            Console.WriteLine("Salário: R$" + roberta.Salario);
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
