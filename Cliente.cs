namespace Bytebank
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string CPF { get => _cpf; set => _cpf = value; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            CPF = cpf;
            Profissao = profissao;
        }
    }
}