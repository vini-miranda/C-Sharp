using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public class Diretor : Funcionarios
    {

        public override double getBonificacao()
        {
            return Salario +(base.getBonificacao());

        }
    }
}
