/*
02. Напишите программу, которая будет выдавать день недели, по заданному номеру:
3 -> Среда
5 -> Пятница
*/
string monday = "Monday";
string tuesday = "Tuesday";
string wednesday = "Wednesday";
string thursday = "Thursday";
string friday = "Friday";
string saturday = "Saturday";
string sunday = "Sunday";

Console.Write("Введите число от 1 до 7 чтобы определить соответственный день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) {
Console.WriteLine(monday);
} else {
    if (number == 2) {
        Console.WriteLine(tuesday);
    } else {
        if (number == 3) {
            Console.WriteLine(wednesday);
        } else {
            if (number == 4) {
                Console.WriteLine(thursday);
            } else {
                if (number == 5) {
                    Console.WriteLine(friday);
                } else {
                    if (number == 6) {
                        Console.WriteLine(saturday);
                    } else {
                        if (number == 7) {
                            Console.WriteLine(sunday);
                        }
                    }
                }
            }
        }
    }
}
