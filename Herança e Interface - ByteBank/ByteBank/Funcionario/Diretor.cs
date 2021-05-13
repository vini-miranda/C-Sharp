using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public class Diretor : Funcionarios
    {
        public Diretor(string cpf) : base(cpf)
        {

        }
        public override double getBonificacao()
        {
            return Salario +(base.getBonificacao());

        }
    }
}
