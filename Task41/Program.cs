// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Количество вводимых чисел: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayInt(numberM);
int resultNumber = HowManyNumGreaterZero(array);
Console.Write($"Количество чисел больше нуля: {resultNumber}");

int[] CreateArrayInt (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите числа (через Enter): ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int HowManyNumGreaterZero(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}