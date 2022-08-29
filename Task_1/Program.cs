// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

void CountPositiveNumbers(string[] args)
{
    Console.Write("Введите количество элементов массива:\t");
    int elementsCount = int.Parse(Console.ReadLine());

    int[] array = new int[elementsCount];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Вывод массива:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result++;
    }
    Console.WriteLine($"Количество чисел в массиве > 0 = {result}");
}

CountPositiveNumbers(args);