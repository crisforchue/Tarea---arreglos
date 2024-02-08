using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int posicionPrimoConDigitosPares = -1;
        int maxDigitosPares = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese un numero {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            if (EsPrimo(numeros[i]))
            {
                int cantidadDigitosPares = ContarDigitosPares(numeros[i]);
                if (cantidadDigitosPares > maxDigitosPares)
                {
                    maxDigitosPares = cantidadDigitosPares;
                    posicionPrimoConDigitosPares = i;
                }
            }
        }

        if (posicionPrimoConDigitosPares != -1)
        {
            Console.WriteLine("El numero con la mayor cantidad de digitos pares se encuentra en la posición {0}.", posicionPrimoConDigitosPares);
        }
        else
        {
            Console.WriteLine("No se encontro el numero.");
        }
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

    static int ContarDigitosPares(int numero)
    {
        int count = 0;
        while (numero != 0)
        {
            int digito = numero % 10;
            if (digito % 2 == 0)
            {
                count++;
            }
            numero /= 10;
        }
        return count;
    }
}

