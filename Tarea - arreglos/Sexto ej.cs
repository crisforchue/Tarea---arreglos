using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el numero entero {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Los numeros con mas de 3 dígitos se encuentran en las siguientes posiciones:");

        for (int i = 0; i < 10; i++)
        {
            if (NumeroDigitos(numeros[i]) > 3)
            {
                Console.WriteLine("Numero {0} en la posicion {1}", numeros[i], i);
            }
        }
    }

    static int NumeroDigitos(int numero)
    {
        int count = 0;
        while (numero != 0)
        {
            count++;
            numero = numero / 10;
        }
        return count;
    }
}
