using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese un numero entero {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int contadorDigitosPrimos = 0;

        foreach (int numero in numeros)
        {
            if (EsPrimo(DigitoInicial(numero)))
            {
                contadorDigitosPrimos++;
            }
        }

        Console.WriteLine("La cantidad de numeros almacenados que comienzan con un digito primo es: " + contadorDigitosPrimos);
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(numero); i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }

    static int DigitoInicial(int numero)
    {
        while (numero >= 10)
        {
            numero /= 10;
        }
        return Math.Abs(numero);
    }
}