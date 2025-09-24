using System;
using System.Collections.Generic;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante() { Nombre = "Ana", Edad = 20 },
            new Estudiante() { Nombre = "Luis", Edad = 22 },
            new Estudiante() { Nombre = "María", Edad = 19 }
        };

        Console.WriteLine("Lista de estudiantes:");
        foreach (Estudiante est in estudiantes)
        {
            Console.WriteLine("Nombre: " + est.Nombre + ", Edad: " + est.Edad);
        }

        Console.ReadKey();
    }
}
