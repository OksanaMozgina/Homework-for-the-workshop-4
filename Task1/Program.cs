﻿/*
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void GetResult(int num1, int num2)
 {
   int result =  1;
   for (int i = 1; i <= num2; i++)
   {
    result = result * num1;
   }
    Console.WriteLine($"{num1}, {num2} -> {result}");
 }
 GetResult(3,5);
