//1. El usuario debe ingresar dos números y la aplicación consola mostrará el resultado de la 
//operación(a + b) * (a - b).La operación debe estar bajo el método Calcular de la clase 
//CalculosMatematicos y el programa principal bajo la clase Program 

using System;

public class CalculosMatematicos
{
    //Metodo que realiza la operacio
    public double Calcular(double a, double b)
    {
        double resultado = (a + b) * (a - b);
        return resultado;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos calc = new CalculosMatematicos();

        //se crea un objeto de la clase CalculosMatematicos
        Console.WriteLine("Ingrese el primer numero (a):");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero (b):");
        double b = Convert.ToDouble(Console.ReadLine());

        //se llama el metodo calcular y se guarda el resultado

        double resultado = calc.Calcular(a, b);

        Console.WriteLine("El resultado de (a+b) * (a-b) es:" + resultado);

    }
}