using Funcionarios;

namespace ClassDiretor
{
    public class Diretor:Funcionario
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

    }
}