/*
47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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
double[,] FillArray(int arg1, int arg2)
{
    double[,] array = new double[arg1, arg2];
    Random random = new Random();
    for (int i = 0; i < arg1; i++)
    {
        for (int j = 0; j < arg2; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10, 2);
        }
    }
    return array;
}
void Print2DArray(double[,] array)
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
Console.ForegroundColor = ConsoleColor.White;
int n = RowColumns();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество столбцов m: "));
Console.ForegroundColor = ConsoleColor.White;
int m = RowColumns();
double[,] userArray = FillArray(n, m);
Print2DArray(userArray);