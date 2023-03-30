using ClassDivisao;
using ClassMultiplicacao;
using ClassSoma;
using ClassSubtracao;

namespace ClassOperacoes
{
    public class Operacoes
    {

        // Criação de Get e Set da class Operacoes
        public Soma soma { get; private set; }
        public Subtracao subtracao { get; private set; }
        public Multiplicacao multiplicacao { get; private set; }
        public Divisao divisao { get; private set; }
        
        public Operacoes()
        {
            this.soma = new Soma();
            this.subtracao = new Subtracao();
            this.multiplicacao = new Multiplicacao();   
            this.divisao = new Divisao();
        }
    }
}