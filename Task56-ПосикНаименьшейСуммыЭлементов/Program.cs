/* 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов. возвращает массив из двух элементов: номер строки 
с наименьшей суммой (нумерация начинается с 0) и саму сумму.
*/
Console.Clear();
string Message(string arg)
{
    return arg;
}
int RowColumns()
{
    int arg = Convert.ToInt32(Console.ReadLine());
    return arg;
}
int[,] FillArray(int arg1, int arg2)
{
    int[,] array = new int[arg1, arg2];
    for (int i = 0; i < arg1; i++)
    {
        for (int j = 0; j < arg2; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void MinSumRow(int[,] array)
{
    {
        int minRow = 0;
        int minSumRow = 0;
        int sumRow = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            minRow += array[0, i];
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }
        //попробовать применить метод создания массива внутри метода!
        //return (minSumRow + 1, minRow);
        CreateArray(minSumRow + 1, minRow);
    }
}
void CreateArray(int arg1, int arg2)
{
    int[] nums = { arg1, arg2 };
    PrintArray(nums);
}
void PrintArray(int[] array)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    Console.WriteLine("]");
}
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество строк n: "));
Console.ForegroundColor = ConsoleColor.White;
int n = RowColumns();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество столбцов m: "));
Console.ForegroundColor = ConsoleColor.White;
int m = RowColumns();
int[,] userArray = FillArray(n, m);
Print2DArray(userArray);
Console.WriteLine();
MinSumRow(userArray);