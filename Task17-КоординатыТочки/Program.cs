/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
int NewCoordinateX(){
    Console.Write("Введите координату X: ");
    int xCoordinate = Convert.ToInt32(Console.ReadLine());
    return xCoordinate;
}
int NewCoordinateY(){
    Console.Write("Введите координату Y: ");
    int yCoordinate = Convert.ToInt32(Console.ReadLine());
    return yCoordinate;
}
double CheckQuoter(double arg1, double arg2){
    if (arg1 > 0 && arg2 > 0){
        System.Console.WriteLine($"Точка с координатами {arg1} и {arg2} принадлежит к I четверти.");
        return 1;
    } else {
        if (arg1 < 0 && arg2 > 0){
            System.Console.WriteLine($"Точка с координатами {arg1} и {arg2} принадлежит ко II четверти.");
            return 1;
        } else {
            if (arg1 < 0 && arg2 < 0){
                System.Console.WriteLine($"Точка с координатами {arg1} и {arg2} принадлежит к III четверти.");
                return 1;
            } else {
                if (arg1 > 0 && arg2 < 0){
                    System.Console.WriteLine($"Точка с координатами {arg1} и {arg2} принадлежит к IV четверти.");
                    return 1;
                }
                return 0;
            }
        }
    }
}
int userX = NewCoordinateX();
int userY = NewCoordinateY();
System.Console.WriteLine(CheckQuoter(userX, userY));