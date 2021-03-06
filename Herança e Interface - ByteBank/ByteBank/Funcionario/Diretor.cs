using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000,cpf)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.5;

        }
    }
}
