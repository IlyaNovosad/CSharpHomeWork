/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
int Quoter(){
Console.Write("Введите номер четверти (значение от 1 до 4): ");
int arg = Convert.ToInt32(Console.ReadLine());
    if (arg < 5 && arg > 0){
        Console.WriteLine($"Введенный номер соответствует {arg} четверти.");
        return 1;
            } else {Console.WriteLine($"Четверти с номером {arg} не существует");
        return 0;
    }
}
int CheckQuoter(int arg){
    if (arg == 1){
        System.Console.WriteLine("Данной четверти соответствует множество координат соответствующих X > 0 и Y > 0.");
        return arg;
    } else {
        if (arg == 2){
            System.Console.WriteLine("Данной четверти соответствует множество координат соответствующих X < 0 и Y > 0.");
            return arg;
        } else {
            if (arg == 3){
                System.Console.WriteLine("Данной четверти соответствует множество координат соответствующих X < 0 и Y < 0.");
                return arg;
            } else {
                if (arg == 4){
                    System.Console.WriteLine("Данной четверти соответствует множество координат соответствующих X > 0 и Y < 0.");
                    return arg;
                }
                return 0;
            }
        }
    }
}
int quoter = Quoter();
Console.WriteLine(CheckQuoter(quoter));