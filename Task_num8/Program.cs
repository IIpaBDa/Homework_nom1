//Семинар 1.
//Домашнее задание.
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

System.Console.WriteLine("Введите число в интервале от 1 до N:");
string text = Console.ReadLine();
int a = int.Parse(text);
int count = 1;

System.Console.WriteLine($"Четные числа от 1 до {a}: ");

while (count <= a)
{
    if (count % 2 == 0)
    {
        System.Console.Write($"{count} ");
        count = count + 1;
    }
    count = count +1;
}
