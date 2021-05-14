using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionario
{
    public abstract class FuncionarioAutenticavel : Funcionarios, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario,string cpf) : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
