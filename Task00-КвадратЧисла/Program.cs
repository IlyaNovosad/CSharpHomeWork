﻿/*
 0. Напишите программау, которая на вход принимает число и выдает
 его квадрат (число умножается на само себя).
*/

Console.Write("Введите число: "); //cw - быстрый вывод Console.WriteLine
int userNumber = Convert.ToInt32(Console.ReadLine());
/*
Convert.ToInt32() - преобразование считанной информаии (получается в формате string) в формат int
Console.ReadLine() - чтение вводимой в терминал информации ()всегда происходит в формате string
*/
Console.Write("Результат выполнения программы: ");
Console.WriteLine(userNumber * userNumber);