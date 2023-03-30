using Funcionarios;
using ClassDiretor;
using ClassBonificacao;
using ClassAuxiliar;
using ClassDesigner;
using ClassGerente;
using ClassSistemaInterno;

public class Program
{
    private static void Main(string[] args)
    {
        void CalcularBonificacao()
        {
            Diretor Mateus = new Diretor("123567");
            Mateus.Nome = "Mateus Pereira";

            Designer Daniel = new Designer("147852");
            Daniel.Nome = "Daniel Frontarolli";

            Auxiliar Eduardo = new Auxiliar("235689");
            Eduardo.Nome = "Eduardo Rabelo";

            GerenteDeContas João = new GerenteDeContas("124578");
            João.Nome = "João Vitor Vanni";

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            gerenciador.Registrar(Mateus);
            gerenciador.Registrar(Daniel);
            gerenciador.Registrar(Eduardo);
            gerenciador.Registrar(João);

            Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
            
        }

        void UsarSistema()
        {
            Diretor Mateus = new Diretor("123567");
            Mateus.Nome = "Mateus Pereira";
            Mateus.Senha = "456";

            GerenteDeContas João = new GerenteDeContas("124578");
            João.Nome = "João Vitor Vanni";
            João.Senha = "125";

            SistemaInterno sistema = new SistemaInterno();

            sistema.Logar(Mateus, "456");
            sistema.Logar(João, "456");
        }

        CalcularBonificacao();
        UsarSistema();
    
    }
}