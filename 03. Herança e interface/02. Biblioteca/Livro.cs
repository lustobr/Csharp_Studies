namespace ClasseLivro
{
    public class Livro
    {

        // Criação de get e set das propriedades da classe Livro
        public string Titulo { get; private set; }
        public string? Autor { get; set; }
        public string ISBN { get; private set; }
        public int AnoDePublicacao { get; set; }
        public string? EstiloLiterário { get; set; }
        public int NumeroDePaginas { get; set; }
        public string? PaisDePublicacao { get; set; }

        // Membro construtor da classe (título e o código IBSN)
        public Livro(string isbn, string titulo) 
        {
            this.ISBN = isbn;
            this.Titulo = titulo;
        }
    
    }
}