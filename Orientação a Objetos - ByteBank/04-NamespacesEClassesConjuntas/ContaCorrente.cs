namespace _04_NamespacesEClassesConjuntas
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int conta;
        public double saldo = 100;

        public string Sacar(double valor)
        {
            if (saldo < valor)
            {
                return "Saldo indisponível para saque";
            }
            else
            {
                saldo -= valor;
                return "Saque realizado com sucesso";
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public string Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return "Saldo indisponível para transferência!";
            }
            else
            {
                saldo -= valor;
                contaDestino.Depositar(valor);
                return "Transferência realizada com sucesso!";
            }
        }
    }
}


