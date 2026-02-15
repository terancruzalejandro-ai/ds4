using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double[] notas = { 85, 90, 78, 92, 88 };
        double promedio = notas.Average();

        Console.WriteLine("Notas ingresadas:");
        foreach (double n in notas)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine("\n\nPromedio = " + promedio);
        Console.ReadKey();
    }
}
