using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public int ContadorErroSaque { get; private set; }

        public int ContadorErroTransferencia { get; private set; }

        public static int TotalContas { get; private set; }
        public int Agencia { get; }
        public int Conta { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if(value < 0)
                {

                }
                else
                {
                    this._saldo = value;
                } 
            }
        }

        //construtores
        public ContaCorrente(int agencia, int conta)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("O campo agência deve ser maior que zero.", nameof(agencia));
            }

            if(conta <= 0)
            {
                throw new ArgumentException("O campo conta deve ser maior que zero", nameof(conta));
            }

            Agencia = agencia;
            Conta = conta;

            TotalContas++;
        }

        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorErroSaque++;
                throw new SaldoInsuficienteException(Saldo,valor);
            }
            else
            {
                _saldo -= valor;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorErroTransferencia++;
                throw new OperacaoFinanceiraException("Operação não realizada.", e);
            }
            
            contaDestino.Depositar(valor); 
        }
    }
}


