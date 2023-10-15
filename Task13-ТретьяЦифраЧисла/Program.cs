/*
13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdPosition(int arg1){
    if (number > 100 && number < 1000) {
        int thirdPosition = number % 10;
        Console.Write($"Третьей цифрой числа {number} является: ");
        return thirdPosition;
    } else {
        Console.Write($"Третьей цифры у чила {number} нет!");
        return -1;
    }
}
Console.WriteLine(ThirdPosition(number));