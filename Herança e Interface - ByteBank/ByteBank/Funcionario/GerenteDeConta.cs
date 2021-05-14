using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            return Salario * 0.25;

        }
    }
}
