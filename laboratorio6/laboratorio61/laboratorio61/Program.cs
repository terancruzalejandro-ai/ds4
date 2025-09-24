using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Número ingresado: " + numero);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar un valor numérico.");
        }

        Console.ReadKey();
    }
}
