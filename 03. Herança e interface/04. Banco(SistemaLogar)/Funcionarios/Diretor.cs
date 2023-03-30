using classAutenticavel;
using Funcionarios;
using ClassAutenticar;
using ClassFuncionariosAutenticavel;

namespace ClassDiretor
{
    public class Diretor: FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
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

    }
}