using System.Text;

partial class Program
{
    static void LidandoCOmFileStream()
    {
        var localDoArquivo = "Contas.txt";
            
        using (var fluxoDoArquivo = new FileStream(localDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024];

            while(numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close();
        }
    }
    static void EscreverBuffer(byte[] buffer, int BytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, BytesLidos);
        Console.Write(texto);
    }
}