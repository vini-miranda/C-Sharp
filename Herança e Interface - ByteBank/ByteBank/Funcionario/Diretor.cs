using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    class Diretor
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }


        public double getBonificacao()
        {
            return Salario;

        }
    }
}
