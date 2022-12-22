// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵) // 2, 4 -> 16
Console.WriteLine( "Введите числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int i =1; 
for (NDegre = 1; i <= b; i++)
{
    NDegre = NDegre * a;
}

Console.WriteLine($"NDegre");
