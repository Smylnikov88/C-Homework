﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3




 var n1 = Decimal.Parse(Console.ReadLine());
            var n2 = Decimal.Parse(Console.ReadLine());
            if (n1 > n2)
                Console.WriteLine(n1);
            else 
                Console.WriteLine(n2);
