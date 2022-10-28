// See https://aka.ms/new-console-template for more information
void StampaArray(int[] array)
{
    Console.Write("[ ");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        if(i != array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine(" ]");
}
int Quadrato(int numero)
{
    return numero * numero;
}
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayQuadrato = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        arrayQuadrato[i] = Quadrato(array[i]);
    }
    return arrayQuadrato;
}
int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i=0; i<array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}
int SommaElementiArrayRicorsivo(int[] array, int i)
{
    if(i < array.Length - 1)
        return array[i] + SommaElementiArrayRicorsivo(array, i + 1);
    return array[i];
}
int Fattoriale(int n)
{
    int fattoriale = 1;
    if (n == 0)
        return fattoriale;
    for (int i = 1; i <= n; i++)
        fattoriale = fattoriale * i;
    return fattoriale;
}
int FattorialeRicorsivo(int n)
{
    if (n > 0)
        return n * FattorialeRicorsivo(n-1);
    return 1;
}
int Fibonacci(int n)
{
    if (n <= 0)
        return 0;
    if (n == 1)
        return 1;
    int n1 = 1;
    int n2 = 1;
    int fibonacci = 0;
    for(int i=2; i<n; i++)
    {
        fibonacci = n1 + n2;
        n1 = n2;
        n2 = fibonacci;
    }
    return fibonacci;
}
int FibonacciRicorsivo(int n)
{
    if (n <= 0)
        return 0;
    else if (n == 1)
        return 1;
    else
        return FibonacciRicorsivo(n - 1) + FibonacciRicorsivo(n - 2);
}


int[] arrayStatico = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Quanti numeri vuoi inserire?");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i=0; i<N; i++)
{
    Console.WriteLine("Inserisci il numero " + (i+1));
    array[i] = Convert.ToInt32(Console.ReadLine());
}
StampaArray(array);
int[] arrayQuadrato = ElevaArrayAlQuadrato(array);
StampaArray(arrayQuadrato);
StampaArray(array);
Console.WriteLine(SommaElementiArray(array));
Console.WriteLine(SommaElementiArrayRicorsivo(array, 0));
Console.WriteLine(SommaElementiArray(arrayQuadrato));
Console.WriteLine("Inserisci un numero");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Fattoriale(numero));
Console.WriteLine(FattorialeRicorsivo(numero));
Console.WriteLine(FibonacciRicorsivo(numero));
Console.WriteLine(Fibonacci(numero));