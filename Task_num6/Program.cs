//Семинар 1.
//Домашнее задание.
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

System.Console.WriteLine("Введите число");
string text = Console.ReadLine();
int number = int.Parse(text);

if (number % 2 == 0)
{
    System.Console.WriteLine($"Да, {number} - четное число");
}
else
{
    System.Console.WriteLine($"Нет, {number} - нечетное число");
}