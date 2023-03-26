using contaCorrente;

class Program
{
    static void Main(string[] args)
    {
        classe ContaDoVictor = new classe();

        ContaDoVictor.titular = "Victor";
        ContaDoVictor.numero_agencia = 40;
        ContaDoVictor.conta = "1010-x";
        ContaDoVictor.saldo = 50;

        Console.WriteLine(ContaDoVictor.titular);
        Console.WriteLine(ContaDoVictor.numero_agencia);
        Console.WriteLine(ContaDoVictor.conta);
        Console.WriteLine(ContaDoVictor.saldo);
    }
}