/*
52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3."
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
void AverageCol(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sumCol = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumCol += array[i, j];
        }
        double averageCol = Convert.ToDouble(sumCol) / Convert.ToDouble((array.GetLength(0)));
        result[j] = Math.Round(averageCol, 2);
    }
    Console.ForegroundColor = ConsoleColor.Green;
    PrintArray(result);
}
void PrintArray(double[] newcollection) {
    int count = newcollection.Length;
    int position = 0;
    Console.Write("[ ");
    while (position < count) {
        Console.Write(newcollection[position] + " ");
        position++;
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
AverageCol(userArray);