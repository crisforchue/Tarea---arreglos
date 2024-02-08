using System;

class Program1
{
    static void Main1()
    {
        int[] numeros = new int[10];
        int MaxPar = int.MinValue;
        int MaxParIndex = -1;

        for (int i = 0; i < 10; i++)
        {
            int IntroNumero;
            do
            {
                Console.Write($"Ingrese numero par {i + 1}: ");
                IntroNumero = Convert.ToInt32(Console.ReadLine());
            } while (IntroNumero % 2 != 0);

            numeros[i] = IntroNumero;

            if (numeros[i] > MaxPar)
            {
                MaxPar = numeros[i];
                MaxParIndex = i;
            }
        }

        if (MaxParIndex != -1)
        {
            Console.WriteLine($"El numero mayor es {MaxPar} en la posicion {MaxParIndex + 1}");
        }
        else
        {
            Console.WriteLine("No tiene numeros pares");
        }
    }
}
