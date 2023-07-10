// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

while (number > 999 | number < -999)
{
    number /= 10;
}
if (number >= 100 | number <= -100)
{
    Console.Write(number + " -> " + number % 10);
}
else
{
    Console.Write(number + " -> третьей цифры нет");
}