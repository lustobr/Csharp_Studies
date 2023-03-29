namespace Funcionarios
{
    public abstract class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cpf { get; private set; }
        public double Salario { get; protected set; }
        public string? Senha { get; set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;           
        }
        
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}