//Семинар 1.
//Домашнее задание.
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

System.Console.WriteLine("Введите первое число ");
string a = Console.ReadLine();
int i = int.Parse(a);

System.Console.WriteLine("Введите второе число "); 
string b = Console.ReadLine();
int j = int.Parse(b);

System.Console.WriteLine("Введите третье число "); 
string c = Console.ReadLine();
int k = int.Parse(c);

int max = 0;

if (max < i)
{
    max = i;
}

if (max < j)
{
    max = j;
}

if (max < k)
{
    max = k;
}

System.Console.WriteLine($"Максимальное число : {max}");
