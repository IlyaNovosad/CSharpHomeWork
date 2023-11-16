/*
Задача 39: Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте, а первый - на
последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
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
void ArrayReverse(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
       temp = array[array.Length - 1 - i];
       array[array.Length - 1 - i] = array[i];
       array[i] = temp;
    }
}
int[] userArray = Array(5);
PrintArray(userArray);
Console.WriteLine();
ArrayReverse(userArray);
PrintArray(userArray);