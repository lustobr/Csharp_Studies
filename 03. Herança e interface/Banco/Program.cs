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
        #region 
        // Funcionario Victor = new Funcionario("123456789", 2000);
        // Victor.Nome = "Victor Martins";

        // Diretor Ana = new Diretor("987654321", 5000);
        // Ana.Nome = "Ana Silva";

        // Console.WriteLine("{0} {1} {2}", Victor.Nome, Victor.Salario, Victor.GetBonificacao());
        // Console.WriteLine("{0} {1} {2}", Ana.Nome, Ana.Salario, Ana.GetBonificacao());

        // GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
        // gerenciador.Registrar(Victor);
        // gerenciador.Registrar(Ana);

        // Console.WriteLine(gerenciador.TotalDeBonificacao);
        // Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

        // Victor.AumentarSalario();
        // Ana.AumentarSalario();

        // Console.WriteLine("{0} {1}", Victor.Nome, Victor.Salario);
        // Console.WriteLine("{0} {1}", Ana.Nome, Ana.Salario);
        #endregion
        #region 
        // void CalcularBonificacao()
        // {
        //     Diretor Mateus = new Diretor("123567");
        //     Mateus.Nome = "Mateus Pereira";

        //     Designer Daniel = new Designer("147852");
        //     Daniel.Nome = "Daniel Frontarolli";

        //     Auxiliar Eduardo = new Auxiliar("235689");
        //     Eduardo.Nome = "Eduardo Rabelo";

        //     GerenteDeContas João = new GerenteDeContas("124578");
        //     João.Nome = "João Vitor Vanni";

        //     GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
        //     gerenciador.Registrar(Mateus);
        //     gerenciador.Registrar(Daniel);
        //     gerenciador.Registrar(Eduardo);
        //     gerenciador.Registrar(João);

        //     Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
            
        // }
        // CalcularBonificacao();
        #endregion

        UsarSistema();
        void UsarSistema()
        {
            Diretor Mateus = new Diretor("123567");
            Mateus.Nome = "Mateus Pereira";
            Mateus.Senha = "456";

            Designer Daniel = new Designer("147852");
            Daniel.Nome = "Daniel Frontarolli";
            Daniel.Senha = "987";

            Auxiliar Eduardo = new Auxiliar("235689");
            Eduardo.Nome = "Eduardo Rabelo";
            Eduardo.Senha = "123";

            GerenteDeContas João = new GerenteDeContas("124578");
            João.Nome = "João Vitor Vanni";
            João.Senha = "125";

            SistemaInterno sistema = new SistemaInterno();

            sistema.Logar(Mateus, "457");
            sistema.Logar(Daniel, "987");
            sistema.Logar(Eduardo, "123");
            sistema.Logar(João, "456");

        }
    
    }
}