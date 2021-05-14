using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
