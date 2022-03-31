using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        //Calcula a bonificação definida na classe de cada funcionário, soma e guarda o total
        public void Registrar(Funcionario funcionario) => _totalBonificacao += funcionario.GetBonificacao();
        public double GetTotalBonificacao() => _totalBonificacao;

    }
}
