using Funcionarios;

namespace classAutenticavel
{
    public abstract class Autenticavel : Funcionario
    {
        protected Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }
        public string? Senha { get; set; }

        public abstract bool Autenticar(string senha);
    }
}