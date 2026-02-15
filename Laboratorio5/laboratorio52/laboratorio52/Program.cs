using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 4];

        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write("Ingrese valor para posición [" + f + "," + c + "]: ");
                matriz[f, c] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz ingresada:");
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write(matriz[f, c] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
