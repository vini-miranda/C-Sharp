using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public class Designer : Funcionarios
    {
        public Designer(string cpf) : base(3000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public override double getBonificacao()
        {
            return Salario * 0.17;

        }
    }
}
