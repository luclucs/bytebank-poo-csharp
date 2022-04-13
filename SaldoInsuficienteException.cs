namespace Bytebank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double ValorSaque { get; }
        public double Saldo { get; }
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
        public SaldoInsuficienteException(double saldo, double valorSaque) : this($"Tentativa de saque do valor de {valorSaque} em uma conta com saldo de {saldo}!")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) { }
    }
}
