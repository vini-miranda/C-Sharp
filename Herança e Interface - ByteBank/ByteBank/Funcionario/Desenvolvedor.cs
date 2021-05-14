using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    class Desenvolvedor : Funcionarios
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
