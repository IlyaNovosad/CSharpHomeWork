/*
Внутри класса Answer напишите метод FindMax, 
который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

    System.Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите третье число: ");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());
    if (firstNumber > secondNumber && firstNumber > thirdNumber) {
        int max = firstNumber;
        Console.WriteLine("Максимальным из трех чисел является: " + max);
        } if (secondNumber > firstNumber && secondNumber > thirdNumber) {
            int max = secondNumber;
            Console.WriteLine("Максимальным из трех чисел является: " + max);
        } if (thirdNumber > firstNumber && thirdNumber > secondNumber) {
                int max = thirdNumber;
                Console.WriteLine("Максимальным из трех чисел является: " + max);
            }