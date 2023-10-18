/*
19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/
Console.Clear();
int NewNumber(){
    System.Console.Write("Введите пятизначное число: ");
    int arg = Convert.ToInt32(Console.ReadLine());
    if (arg > 10000 & arg < 99999){
        return arg;
    } else {
        System.Console.WriteLine($"Введенное число {arg} не является пятизначным.");
        return arg;
    }
}
int Pal(int arg){
    int newArg = 0;
    for (int i = arg; i > 0; i /= 10){
        newArg = newArg * 10 + i % 10;
    }
    if (newArg == arg){
    System.Console.WriteLine("Это палиндром.");
    return 1;
    } else {
        System.Console.WriteLine("Это не палиндром");
        return 0;
    }
}
int number = NewNumber();
System.Console.WriteLine(Pal(number));