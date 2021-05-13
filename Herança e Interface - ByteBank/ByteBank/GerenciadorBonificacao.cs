using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionario;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _total;

        public void Registrar(Funcionarios funcionario)
        {
            _total += funcionario.getBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            _total += diretor.getBonificacao();
        }

        public double getBonificacao()
        {
            return _total;
        }
    }
}
