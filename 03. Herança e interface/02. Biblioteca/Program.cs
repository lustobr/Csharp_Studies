using ClasseLivro;

public class Program
{
    private static void Main(string[] args)
    {

        // Criação do objeto (livro01)
        Livro livro01 = new Livro("123456789", "As aventuras de Tintim");

        Console.WriteLine($"O título do livro: {livro01.Titulo}\nO código ISBN do livro: {livro01.ISBN}");
    
        /*
        Output:

        O título do livro: As aventuras de Tintim
        O código ISBN do livro: 123456789
        
        */
    
    }
}