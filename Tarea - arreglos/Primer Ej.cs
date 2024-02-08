using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        int maxNumber = int.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese un numero {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
                maxIndex = i;
            }
        }

        Console.WriteLine($"El numero mas grande es {maxNumber} en la posicion {maxIndex + 1}");
    }
}