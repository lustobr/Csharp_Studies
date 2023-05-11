Console.WriteLine("Digite um número: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] MatrizM1 = new int[N, N];
int[,] MatrizM2 = new int[N, N];
int[,] MatrizM3 = new int[N, N];

for (int me1 = 0; me1 < N; me1++) 
{
    for (int mi1 = 0; mi1 < N; mi1++) 
    {
        Console.WriteLine($"Digite um número para posição [{me1}, {mi1}]: ");
        int P = Convert.ToInt32(Console.ReadLine());
        MatrizM1[me1 , mi1] = P;
    }
}

for (int me2 = 0; me2 < N; me2++) 
{
    for (int mi2 = 0; mi2 < N; mi2++) 
    {
        Console.WriteLine($"Digite um número para posição [{me2}, {mi2}]: ");
        int P = Convert.ToInt32(Console.ReadLine());
        MatrizM2[me2 , mi2] = P;
    }
}

for (int me3 = 0; me3 < N; me3++) 
{
    for (int mi3 = 0; mi3 < N; mi3++) 
    {
        if (MatrizM2[me3,mi3] >= MatrizM1[me3,mi3]) {
            MatrizM3[me3,mi3] = MatrizM2[me3,mi3];
        } 
        else 
        {
            MatrizM3[me3,mi3] = MatrizM1[me3,mi3];
        }
    }
}

for (int i = 0; i < N; i++) {
    for(int l = 0; l < N; l++) {
        Console.Write(MatrizM3[i,l] + " ");
    }
    Console.WriteLine();
}