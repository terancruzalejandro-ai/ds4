namespace laboratorio3;

internal class Lab3
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, suma;

        Console.Write("Ingrese el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumero;

        Console.WriteLine("La suma de {0} y {1} es {2}", primerNumero, segundoNumero, suma);

    }
}