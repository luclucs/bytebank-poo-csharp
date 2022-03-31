namespace ByteBank.Funcionarios
{
    //Não pode ser instanciado um objeto do tipo Funcionario direto
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            //Console.WriteLine("Criando funcionário!");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
