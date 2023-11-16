/*
34. Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
Аргументы, передаваемые в метод/функцию:
'124, 378, 593, 821, 456'
Массив:
124     378     593     821     456 
Количество четных элементов: 3
*/
Console.Clear();
int[] NewArray(int length)
{
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
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
void Even(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(count);
}
Console.Write("Please insert array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(size);
PrintArray(array);
Console.WriteLine(array);
Console.Write("The number of even array elements is: ");
Even(array);