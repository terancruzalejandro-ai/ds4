using System;

class Program
{
    private int[] sueldos; // Declaramos un vector

    public void Cargar()
    {
        sueldos = new int[5]; // Inicializamos en 5 elementos (índices 0 a 4)
        for (int f = 0; f < 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + (f + 1) + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("\nLos sueldos de los operarios:");
        for (int f = 0; f < 5; f++)
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.ReadKey();
    }

    // Main principal
    static void Main(string[] args)
    {
        Program pv = new Program();
        pv.Cargar();
        pv.Imprimir();
    }
}
