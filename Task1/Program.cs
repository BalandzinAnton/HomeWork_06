// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();
WriteLine("Какое колличество чисел собираетесь вводить: ");
int length = int.Parse(ReadLine()!);
int[] ArrayOut = GetArray(length);
PrintArray(ArrayOut);
SumNumber(ArrayOut);



int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        WriteLine($"Введите число с индексом {i}:\t ");
        array[i] = int.Parse(ReadLine()!);
    }
    return array;
}

void SumNumber(int[] Arr)
{
    int sum = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i]>0)
        {
            sum += 1;
        }
    }
    WriteLine($"Колличество введенных положительных чисел: {sum}");
}

void PrintArray(int[] inArray)
{
    Write("[");
    for(int i=0; i<inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    WriteLine($"{inArray[inArray.Length-1]}]");

}
