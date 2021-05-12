namespace _05_GetAndSet
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
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

        //public Cliente titular;
        //public int agencia;
        //public int conta;
        private double _saldo = 100;

        public string Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return "Saldo indisponível para saque";
            }
            else
            {
                _saldo -= valor;
                return "Saque realizado com sucesso";
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public string Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return "Saldo indisponível para transferência!";
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return "Transferência realizada com sucesso!";
            }
        }
    }
}


