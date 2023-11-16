/*
46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/
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
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество строк n: "));
int n = RowColumns();
System.Console.Write(Message("Введите количество столбцов m: "));
int m = RowColumns();
int[,] userArray = FillArray(n, m);
Print2DArray(userArray);