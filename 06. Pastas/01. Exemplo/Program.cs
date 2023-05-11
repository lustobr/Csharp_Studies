using System.Text;
using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        var localDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(localDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            // var linha = leitor.ReadLine();
            // var texto = leitor.ReadToEnd();
            // var numero = leitor.Read();

            while(!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha!);

                var msg = $"{contaCorrente.Titular!.Nome} : Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, saldo {contaCorrente.Saldo}";
                Console.WriteLine(msg);
            }   
        }
        Console.ReadLine();
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(',');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2].Replace('.', ',');
        var nometitular = campos[3];

        var agenciaComInt = int.Parse(agencia);
        var numeroComInt = int.Parse(numero);
        var saldoComDouble = double.Parse(saldo);

        var titular = new Cliente();
        titular.Nome = nometitular;

        var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }
}