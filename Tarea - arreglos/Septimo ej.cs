using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int suma = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el numero entero {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            suma += numeros[i];
        }

        int promedio = suma / 10;

        Console.WriteLine("El promedio entero de los datos es: {0}", promedio);
    }
}