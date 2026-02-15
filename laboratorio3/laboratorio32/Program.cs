using System;

public class CalculosMatematicos
{
    // Método que realiza la operación (a + b) * (a - b)
    public double Calcular(double a, double b)
    {
        double resultado = (a + b) * (a - b);
        return resultado;
    }

    // calcula el área de un círculo
    public double CalculoArea(double radio)
    {
        double area = Math.PI * Math.Pow(radio, 2);
        return area;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // Se crea un objeto de la clase CalculosMatematicos
        CalculosMatematicos calc = new CalculosMatematicos();

        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Se llama al método CalculoArea y se guarda el resultado
        double area = calc.CalculoArea(radio);

        Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
    }
}
