//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int N = int.Parse(a);
int NegN = 2;

while(NegN <= N)
{
Console.Write($"{NegN} ");
NegN +=2;
}

