/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
int number = RandomNumber();
int RandomNumber() {
    int newRandom =new Random().Next(99, 999);
    return newRandom;
}
int FirstPosition(int number) {
    int firstPosition = number / 100;
    return firstPosition;
}
int ThirdPosition(int number) {
    int thirdPosition = number % 10;
    return thirdPosition;
}

Console.WriteLine(number);
Console.WriteLine(FirstPosition(number)*10 + ThirdPosition(number));
