/*
Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования
*/
Console.Clear();
int[] Array(int size)
{
    Random random = new Random();
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = random.Next(0, 10);
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
void CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(String.Join(", ", copy));
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("]");
}
int[] userArray = Array(5);
PrintArray(userArray);
Console.WriteLine();
CopyArray(userArray);
