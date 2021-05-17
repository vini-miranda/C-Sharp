namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalContas { get; private set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }

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

        //public Cliente titular;
        //public int agencia;
        //public int conta;
        
        //construtores
        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;

            TaxaOperacao = 30 / TotalContas;

            TotalContas++;
        }

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


