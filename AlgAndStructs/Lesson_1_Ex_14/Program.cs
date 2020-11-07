// 14. *Автоморфные числа.
// Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата.
// Например, 25^2 = 625.
// Напишите программу, которая вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.

using System;
using System.Collections.Generic;

namespace Lesson_1_Ex_14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = GetAutomorfs(100000);
            foreach (var element in result)
            {
                Console.WriteLine($"{element} -- {element.PowerOf(2)}");
            }
        }

        public static List<int> GetAutomorfs(int n)
        {
            var result = new List<int>();
            for (var i = 0; i <= n; i++)
            {
                if (IsAutomorf(i))
                    result.Add(i);
            }
            return result;
        }
        public static bool LastNumbersEquals(long input, int to)
        {
            if (input.Lenght() < to.Lenght())
                return false;
            
            var devider =  10.PowerOf((uint)to.Lenght());
            var inputLast = input.Abs() % devider;
            var toLast = to.Abs() % devider;
            return inputLast == toLast;
        }

        public static bool IsAutomorf(int n)
        {
            
            return LastNumbersEquals(n.PowerOf(2), n);
        }
    }
}