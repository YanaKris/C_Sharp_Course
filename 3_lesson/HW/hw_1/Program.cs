// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет 12821 -> да 23432 -> да
  Console.WriteLine("Введите 5 значное число");
  string a = Console.ReadLine();
  int N = int.Parse(a);

        if (N < 100000 && N > 9999)
        {
            Console.Write("{принято} ");
        }
       else 
        Console.Write("{error}");

        if (N/10000 == N%10 & N/1000==N/10)
        {
            Console.Write("{да} ");
        }
        else
        Console.Write("{нет}");

  
    