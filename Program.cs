// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int position2 = (number / 10 % 10);
// if (number > 99 && number < 1000)
// {
//     Console.WriteLine($"Вторая цифра в числе {number} - это {position2}");
// }
// else
// {
//     Console.WriteLine($"Введенное число {number} - не является трехзначным");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите  число от 0 до 9999: ");
int number = Convert.ToInt32(Console.ReadLine());
int position3 = (number / 10 % 10);
int position4 = (number % 10);

if (number > 99 && number < 1000)
{
    Console.WriteLine($"Третья цифра в числе {number} - это {position4}");
}
if (number < 100)
{
    Console.WriteLine($"У введенного числа {number} - нет третьей цифры");
}
if (number > 999 && number < 9999)
{
    Console.WriteLine($"Третья цифра в числе {number} - это {position3}");
}
else
{
    Console.WriteLine($"Введенное число {number}  -  вне заданного диапазона");
}