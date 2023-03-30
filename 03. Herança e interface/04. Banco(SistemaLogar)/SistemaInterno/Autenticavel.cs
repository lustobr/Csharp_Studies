using Funcionarios;

namespace classAutenticavel
{
    public interface IAutenticavel
    {
        public string? Senha { get; set; }

        public abstract bool Autenticar(string senha);
    }
}