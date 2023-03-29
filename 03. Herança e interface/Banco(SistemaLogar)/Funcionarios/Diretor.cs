using classAutenticavel;
using Funcionarios;

namespace ClassDiretor
{
    public class Diretor:Autenticavel
    {
        public Diretor(string cpf):base(cpf, 5000)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.50;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}