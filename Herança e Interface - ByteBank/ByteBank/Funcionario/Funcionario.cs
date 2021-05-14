using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public abstract class Funcionarios
    {
        public static int ContaFuncionarios { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }

        public Funcionarios(double salario,string cpf)
        {
            Cpf = cpf;
            Salario = salario;
            ContaFuncionarios++;
        }

        public abstract void AumentarSalario();


        public abstract double getBonificacao();
    }
}
