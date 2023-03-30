using Funcionarios;

namespace ClassAuxiliar
{
    public class Auxiliar:Funcionario
    {
        public Auxiliar(string cpf):base(cpf, 2000)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}