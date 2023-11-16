/*
Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/
Console.Clear();
void Message(string arg)
{
    Console.WriteLine(arg);
}
int Args()
{
    int arg = Convert.ToInt32(Console.ReadLine());
    return  arg;
}
bool Triangle(int arg1, int arg2, int arg3)
{
    if (arg1 + arg2 > arg3 && arg2 + arg3 > arg1 && arg1 + arg3 > arg2) 
    {
        return true;
    }
    else
    {
        return false;
    }
}
Message("Введите длину для стороны A");
int pointA = Args();
Message("Введите длину для стороны B");
int pointB = Args();
Message("Введите длину для стороны C");
int pointC = Args();
Console.WriteLine($"Сторона A: {pointA}; Сторона B: {pointB}; Сторона C: {pointC};");
Console.WriteLine();
System.Console.WriteLine(Triangle(pointA, pointB, pointC));