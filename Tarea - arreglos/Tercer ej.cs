using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int posicionDelPrimo = -1;
        int maxPrimo = int.MinValue;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese un numero {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            if (EsPrimo(numeros[i]) && numeros[i] > maxPrimo)
            {
                maxPrimo = numeros[i];
                posicionDelPrimo = i;
            }
        }

        if (posicionDelPrimo != -1)
        {
            Console.WriteLine("El numero mayor es es {0} y se encuentra en la posicion {1}", maxPrimo, posicionDelPrimo);
        }
        else
        {
            Console.WriteLine("No hay numeros primos");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        int limite = (int)Math.Floor(Math.Sqrt(numero));

        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}w