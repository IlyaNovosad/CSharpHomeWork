/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
Console.Write("Введите число lдля проверки: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiple(int arg1) {
    int multipleOne = arg1 % 7;
    int multipleTwo = arg1 % 23;
    if (multipleOne == 0 && multipleTwo == 0) {
        Console.WriteLine($"Число {arg1} кратно 7 и 23");
        return 1;
    } else {
        Console.WriteLine($"{arg1} не кратно одновременно 7 и 23");
        return 0;
    }
}
Console.WriteLine(Multiple(number));