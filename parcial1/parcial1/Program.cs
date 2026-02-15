using System;
namespace pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int suma = 0;

            Console.WriteLine("PARCIAL 1 MATRIZ");
            Console.Write("Ingrese el tamaño de la matriz (N x N): ");
            n = int.Parse(Console.ReadLine());

            // Valida que sea par
            if (n % 2 != 0)
            {
                Console.WriteLine("El número debe ser PAR.");
                return;
            }

            int[,] matriz = new int[n, n];
            Random random = new Random();

            // Llena la matriz con el patrón:
            // Solo la diagonal principal tiene números entre 101 y 200
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        // Verifica si es la esquina superior izquierda o inferior derecha
                        if (i == 0 || i == n - 1)
                        {
                            matriz[i, j] = 0; // esquinas en 0
                        }
                        else
                        {
                            matriz[i, j] = random.Next(101, 201);
                        }
                    }
                    else
                    {
                        matriz[i, j] = 0;
                    }
                }
            }

            // muestra la matriz
            Console.WriteLine("\nMatriz generada:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j].ToString("000") + " ");
                }
                Console.WriteLine();
            }

            // Calcular la suma de todos los elementos
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    suma += matriz[i, j];
                }
            }

            Console.WriteLine($"\nLa suma total de los elementos es: {suma}");
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
