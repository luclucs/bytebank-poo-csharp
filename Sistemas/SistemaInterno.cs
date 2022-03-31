namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        //Método requer um funcionário que derive da interface
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Usuário logado!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorreta!");
                return false;
            }
        }
    }
}
