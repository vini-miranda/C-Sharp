using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double Valor { get; }
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo,double valor) : 
            this("ERRO!! \nTentativa de saque/transferencia no valor de  R$" + valor + " em uma conta com saldo de R$" + saldo)
        {
            Saldo = saldo;
            Valor = valor;
        }
        public SaldoInsuficienteException(string message) : base(message)
        {

        }
    }
}
