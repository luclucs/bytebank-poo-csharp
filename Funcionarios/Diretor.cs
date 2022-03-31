namespace ByteBank.Funcionarios
{
    //Deriva tanto de Funcionário, como da Interface Autenticável
    public class Diretor : FuncionarioAutenticavel
    {
        //Constructor do diretor que repassa o parâmetro cpf para a classe base
        public Diretor(string cpf) : base(5000, cpf)
        {
            //Console.WriteLine("Criando diretor!");
        }
        public override void AumentarSalario() => Salario *= 1.15;
        public override double GetBonificacao() => Salario * 0.5;
    }
}
