﻿// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11 //82 -> 10 

int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(s);


