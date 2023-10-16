/*
12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int Multiple(int arg1, int arg2) {
    int multiple = arg1 % arg2;
    if (multiple > 0) {
        Console.Write($"Число {arg1} не кратно {arg2}, остаток равен: ");
        return multiple;
    } else {
        Console.WriteLine($"{arg1} кратно {arg2}");
        return 0;
    }
}
Console.WriteLine(Multiple(numberOne, numberTwo));