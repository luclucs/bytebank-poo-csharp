using Bytebank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new("Lucas", "123.456.789-10", "Dev C#");
            ContaCorrente contaUm = new(cliente, 1001, 20123);
            //Console.WriteLine($"Cliente: {contaUm.Titular.Nome}\nProfissão: {contaUm.Titular.Profissao}\nCPF: {contaUm.Titular.CPF}\nAgência: {contaUm.Agencia}\nNúmero da conta: {contaUm.Numero}\nSaldo: {contaUm.Saldo}\nAté o momento, foram criadas {ContaCorrente.TotalDeContasCriadas} conta(s) no Bytebank!");
            //CalcularBonificacao(); 
            //UsarSistema();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario paulo = new Designer("833.222.048-39");
            paulo.Nome = "Paulo";

            Funcionario vitoria = new Diretor("159.753.398-04");
            vitoria.Nome = "Vitoria";

            Funcionario auxiliar = new Auxiliar("981.198.778-53");
            auxiliar.Nome = "Auxiliar";

            Funcionario samara = new GerenteDeConta("326.985.628-89");
            samara.Nome = "Samara";

            Desenvolvedor lucas = new Desenvolvedor("456.175.468-20");
            lucas.Nome = "Lucas";

            gerenciadorBonificacao.Registrar(paulo);
            gerenciadorBonificacao.Registrar(vitoria);
            gerenciadorBonificacao.Registrar(auxiliar);
            gerenciadorBonificacao.Registrar(samara);
            gerenciadorBonificacao.Registrar(lucas);

            Console.WriteLine($"Total de bonificações do mês: {gerenciadorBonificacao.GetTotalBonificacao()}");
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor vitoria = new Diretor("159.753.398-04");
            vitoria.Nome = "Vitoria";
            vitoria.Senha = "123";

            GerenteDeConta mayan = new GerenteDeConta("326.985.628-89");
            mayan.Nome = "Mayan";
            mayan.Senha = "456";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(vitoria, "123");
            sistemaInterno.Logar(mayan, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }
    }
}