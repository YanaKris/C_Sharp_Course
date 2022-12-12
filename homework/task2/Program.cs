// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3");
int num3 = int.Parse(Console.ReadLine());

int max;

max = num1;
if (num2 > num1)
    {
    if (num3>num2)
    {
        max = num3;
        Console.WriteLine($"max={num3}");
    }
    else
    {
        max = num2;
        Console.WriteLine($"max={num2}");
    }
}
else
{
    if (num3>num1)
    {
        max = num3;
        Console.WriteLine($"max={num3}");
    }
    else
    {
       Console.WriteLine($"max={num1}");
    }
};
