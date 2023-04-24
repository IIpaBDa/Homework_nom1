//Семинар 1.
//Домашнее задание.
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

System.Console.WriteLine("Введите первое число ");
string a = Console.ReadLine();
int i = int.Parse(a);

System.Console.WriteLine("Введите второе число ");
string b = Console.ReadLine();
int j = int.Parse(b);

if (i>j)
{
    System.Console.WriteLine($"Большее число {i}");
    System.Console.WriteLine($"Меньшее число {j}");
}
else if (j>i)
{
    System.Console.WriteLine($"Большее число {j}");
    System.Console.WriteLine($"Меньшее число {i}");
}
else
{
    System.Console.WriteLine("Числа равны");
}