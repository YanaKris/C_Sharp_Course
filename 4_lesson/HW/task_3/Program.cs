// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
 Random Random = new Random();
 
 Console.WriteLine("");
 for (int i = 0; i < array.Length; i++)
     {
         array[i] = Random.Next(0, 8);
         Console.Write("{0} ", array[i]);
     }