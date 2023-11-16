/*
36. Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Аргументы, передаваемые в метод/функцию:
'18, 76, 11'
На выходе:
18      76      11  
Сумма нечетных элементов: 76
*/
Console.Clear();
int[] NewArray(int length)
{
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        newArray[i] = new Random().Next(1, 10);
    }
    return newArray;

}
void PrintArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("]");
    Console.ResetColor();
}
void Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = array[i] + sum;
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(sum);
}
Console.Write("Please insert array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(size);
PrintArray(array);
Console.WriteLine(array);
Console.Write("The sum of elements with odd positions is equal to: ");
Sum(array);