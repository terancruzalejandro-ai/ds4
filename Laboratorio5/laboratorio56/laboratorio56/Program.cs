using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> paises = new Dictionary<string, string>()
        {
            { "Panamá", "Ciudad de Panamá" },
            { "España", "Madrid" },
            { "México", "Ciudad de México" },
            { "Argentina", "Buenos Aires" }
        };

        Console.WriteLine("Países y sus capitales:");
        foreach (KeyValuePair<string, string> par in paises)
        {
            Console.WriteLine("País: " + par.Key + " - Capital: " + par.Value);
        }

        Console.ReadKey();
    }
}
