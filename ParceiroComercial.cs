using ByteBank.Sistemas;

namespace ByteBank
{
    //Deriva somente da interface
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha) => Senha == senha;
    }
}
