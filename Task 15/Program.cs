// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine());

if(number>0 && number<8)
{
    if(number>5 && number <8)
    {
        Console.WriteLine(number + " -> да");
    }
    else
    {
        Console.WriteLine(number + " -> нет");
    }
}
else
{
    Console.Write("неверный ввод");
}
