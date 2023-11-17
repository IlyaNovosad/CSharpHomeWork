/*
Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();
string Message(string arg)
{
    return arg;
}
int UserNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
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
bool Checking(int[,] array, int row, int column)
{
    if (row > array.GetLength(0) && column > array.GetLength(1))
    {
        return false;
    }
    else return true;
}
void FindIndex(int[,] array, int row, int column)
{
    int result = 0;
    if (Checking(array, row, column) == true)
    {
        result = array[row, column];
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Значения с номером строки {row} и номером столбца {column} = {result}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Значения с номером строки {row} и номером столбца {column} в данном масииве нет!");
    }
}

Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество строк n: "));
Console.ForegroundColor = ConsoleColor.White;
int n = RowColumns();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество столбцов m: "));
Console.ForegroundColor = ConsoleColor.White;
int m = RowColumns();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите номер столбца для поиска: "));
Console.ForegroundColor = ConsoleColor.White;
int userRow = UserNumber();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите номер строки для поиска: "));
Console.ForegroundColor = ConsoleColor.White;
int userColumn = UserNumber();
int[,] userArray = FillArray(n, m);
Print2DArray(userArray);
Console.WriteLine();
FindIndex(userArray, userRow, userColumn);