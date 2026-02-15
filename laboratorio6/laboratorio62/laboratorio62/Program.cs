using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Ingrese el dividendo: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el divisor: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a / b;
            Console.WriteLine("Resultado: " + resultado);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar solo números.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }

        Console.ReadKey();
    }
}
