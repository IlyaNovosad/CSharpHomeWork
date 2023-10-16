/*
16.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 -> нет
*/
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Sqr(int arg1, int arg2) {
    int sqrOne = arg1 * arg1;
    int sqrTwo = arg2 * arg2;
    if (arg1 == sqrTwo || arg2 == sqrOne) {
        Console.WriteLine($"Число {arg1} является квадратом числа {arg2}.");
        return 1;
    } else {
        Console.WriteLine($"Число {arg1} не является квадратом числа {arg2}.");
        return 0;
    }
}
Console.WriteLine(Sqr(firstNumber, secondNumber));