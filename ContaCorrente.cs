namespace Bytebank
{
    public class ContaCorrente
    {
        public int contadorSaquesNaoPermitidos { get; private set; }
        public int contadorTransferenciasNaoPermitidas { get; private set; }
        public static double TaxaDeOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }
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
            if (agencia <= 0)
                throw new ArgumentException("Agência deve ser maior que 0!", nameof(agencia));
            if (numero <= 0)
                throw new ArgumentException("Número da conta deve ser maior que 0!", nameof(numero));
            this.Titular = Titular;
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaDeOperacao = 30 / TotalDeContasCriadas;
        }
        //Métodos de operações de uma conta bancária
        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            if (_saldo < valor)
            {
                contadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            _saldo -= valor;

        }

        public void Depositar(double valor) => _saldo += valor;

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            try
            {
                Sacar(valor);
                contaDestino.Depositar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                contadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada", ex);
            }
        }
    }
}