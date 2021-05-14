using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    class Auxiliar : Funcionarios
    {
        public Auxiliar(string cpf) : base(2000,cpf)
        {

        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

        public override double getBonificacao()
        {
            return Salario * 0.20;

        }
    }
}
