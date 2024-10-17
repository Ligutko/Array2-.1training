using System;

class Program
{
    static void Main()
    {
        // Введення розміру масиву
        Console.Write("Введіть розмір масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Random random = new Random();

        // Заповнюємо масив випадковими числами у діапазоні від -50 до 50
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-50, 51);
        }

        // Виведення вихідного масиву
        Console.WriteLine("Вихідний масив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Підрахунок кількості від'ємних елементів
        int negativeCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negativeCount++;
            }
        }

        // Виведення результату
        Console.WriteLine($"Кількість від'ємних елементів у масиві: {negativeCount}");
    }
}
