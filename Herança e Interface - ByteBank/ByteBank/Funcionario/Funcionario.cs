using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public class Funcionarios
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

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public virtual double getBonificacao()
        {
            return this.Salario * 0.10;
            
        }
    }
}
