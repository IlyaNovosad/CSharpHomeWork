/*
58. Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
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
void MultArray(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] result = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                if (arrayOne.GetLength(0) == arrayTwo.GetLength(0) && arrayOne.GetLength(1) == arrayTwo.GetLength(1))
                {
                    result[i, j] += arrayOne[i, k] * arrayTwo[k, j];
                }
                else Console.WriteLine("Массивы нельзя перемножить");
            }
        }
    }
    Print2DArray(result);
}
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество строк n первого массива: "));
Console.ForegroundColor = ConsoleColor.White;
int nOne = RowColumns();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество столбцов m первого массива: "));
Console.ForegroundColor = ConsoleColor.White;
int mOne = RowColumns();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество строк n второго массива: "));
Console.ForegroundColor = ConsoleColor.White;
int nTwo = RowColumns();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(Message("Введите количество столбцов m второго массива: "));
Console.ForegroundColor = ConsoleColor.White;
int mTwo = RowColumns();
int[,] userArrayOne = FillArray(nOne, mOne);
int[,] userArrayTwo = FillArray(nTwo, mTwo);
Print2DArray(userArrayOne);
Console.WriteLine();
Print2DArray(userArrayTwo);
Console.WriteLine();
MultArray(userArrayOne, userArrayTwo);