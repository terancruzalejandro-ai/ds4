using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Número válido: " + numero);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: El valor ingresado no es un número entero.");
        }
        finally
        {
            Console.WriteLine("Finalizando la ejecución (bloque finally).");
        }

        Console.ReadKey();
    }
}
