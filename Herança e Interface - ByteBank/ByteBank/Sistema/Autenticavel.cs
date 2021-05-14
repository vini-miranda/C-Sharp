using ByteBank.Funcionario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistema
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);

    }
}
