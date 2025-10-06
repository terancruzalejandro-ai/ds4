using System;

public class CalculosMatematicos
{
    // Método que realiza la operación (a + b) * (a - b)
    public double Calcular(double a, double b)
    {
        double resultado = (a + b) * (a - b);
        return resultado;
    }

    // Método que calcula el área de un círculo
    public double CalculoArea(double radio)
    {
        double area = Math.PI * Math.Pow(radio, 2);
        return area;
    }

    // calcula el perímetro de un rectángulo
    public double CalcularPerimetroRectangulo(double lado1, double lado2)
    {
        double perimetro = 2 * (lado1 + lado2);
        return perimetro;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear un objeto de la clase CalculosMatematicos
        CalculosMatematicos calc = new CalculosMatematicos();

        // Pedir los lados del rectángulo
        Console.WriteLine("Ingrese la longitud del primer lado del rectángulo:");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la longitud del segundo lado del rectángulo:");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        // Llamar al método que calcula el perímetro
        double perimetro = calc.CalcularPerimetroRectangulo(lado1, lado2);

        // Mostrar el resultado
        Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
    }
}
