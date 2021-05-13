using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public class Diretor : Funcionarios
    {
        public Diretor(double salario,string cpf) : base(salario,cpf)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double getBonificacao()
        {
            return Salario +(base.getBonificacao());

        }
    }
}
