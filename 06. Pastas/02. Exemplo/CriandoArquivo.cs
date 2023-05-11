using System.Text;

partial class Program
{
    // Criar arquivo com bytes
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "115, 7842, 4725.12, Victor Martins";
            var enconding = Encoding.UTF8;
            var bytes = enconding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            
        }
    }

    
    // Criar arquivo com StreamWriter
    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("154,5438,65.1,Luiz Souza");
        }
    }
}
