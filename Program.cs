// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int position2 = (number / 10 % 10);
if (number > 99 && number < 1000)
{
    Console.WriteLine($"Вторая цифра в числе {number} - это {position2}");
}
else
{
    Console.WriteLine($"Введенное число {number} - не является трехзначным");
}