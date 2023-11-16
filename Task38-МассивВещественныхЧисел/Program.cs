/*
38. Напишите программу для работы с массивом вещественных чисел.
Аргументы, передаваемые в метод/функцию:
'3.17, 8.94, 2.36, 5.72, 0.85'
На выходе:
Массив:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09
*/
Console.Clear();
double[] Array(int size)
{
    Random random = new Random();
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round(random.NextDouble() * 10, 2);
    }
    return newArray;
}
void PrintArray(double[] array)
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
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];          
    }
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
double[] userArray = Array(5);
PrintArray(userArray);
Console.WriteLine();
Console.WriteLine(FindMax(userArray) - FindMin(userArray));
