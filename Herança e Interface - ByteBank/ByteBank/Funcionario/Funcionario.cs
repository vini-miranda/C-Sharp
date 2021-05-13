using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public class Funcionarios
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }


        public virtual double getBonificacao()
        {
            return this.Salario * 0.10;
            
        }
    }
}
