using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistema
{
    class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario,string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida!");
                return false;
            }
        }
    }
}
