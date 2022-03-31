namespace Bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        private int _agencia;
        public int Agencia
        {
            get => _agencia;
            set
            {
                if (value <= 0)
                    return;
                _agencia = value;
            }
        }
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get => _saldo;
            set
            {
                if (value < 0)
                    return;
                _saldo = value;
            }
        }

        //Constructor da conta, requer um titular
        public ContaCorrente(Cliente Titular, int agencia, int numero)
        {
            this.Titular = Titular;
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor) => _saldo += valor;

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
                return false;
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}