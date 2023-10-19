/*
22. Напишите программу, которая принимает на вход число(N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();
int Prompt(string message){
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Sqr(int arg){
    int sqr = 0;
    for (int i = 1; i <= arg; i++)
    System.Console.WriteLine($"i * i = {Math.Pow(i, 2)}");
    return 1;
}
int userNumber = Prompt("Введите число N: ");
System.Console.WriteLine(userNumber);
Sqr(userNumber);
