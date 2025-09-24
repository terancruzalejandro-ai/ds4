using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Elementos del arreglo:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }

        Console.ReadKey();
    }
}
