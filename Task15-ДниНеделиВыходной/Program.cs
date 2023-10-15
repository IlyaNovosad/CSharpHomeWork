/*
15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите число от 1 до 7 для проверки выходного дня: ");
int number = Convert.ToInt32(Console.ReadLine());

int Vocation(int arg1) {
    if (arg1 < 1 && arg1 > 7) {
        return 0;
    } else {
        if (arg1 > 0 && arg1 <= 5) {
            Console.WriteLine($"День под номером {arg1} является рабочим.");
            return arg1;
        } else {if (arg1 >= 6 && arg1 <= 7) {
                Console.WriteLine($"День под номером {arg1} является выходным.");
                return 1;
            }
            Console.WriteLine($"Дня с номером {arg1} не существует в неделе.");
            return -1;
        }
    }
}
Console.WriteLine(Vocation(number));