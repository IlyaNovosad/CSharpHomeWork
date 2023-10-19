/*
23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
//Console.Clear();
int Prompt(string message){
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Sqr(int arg){
    for (int i = 1; i <= arg; i++)
    System.Console.WriteLine($"i * i = {Math.Pow(i, 3)}");
    return 1;
}
int userNumber = Prompt("Введите число N: ");
System.Console.WriteLine(userNumber);
Sqr(userNumber);
