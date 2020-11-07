// Найти максимальное из четырех чисел. Массивы не использовать.

using System;

namespace Lesson_1_Ex_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var a = random.Next(-1000,1000);
            var b = random.Next(-1000,1000);
            var c = random.Next(-1000,1000);
            var d = random.Next(-1000,1000);

            var max = GetMax(a, b, c, d);
            Console.WriteLine($"a = {a}\n" +
                              $"b = {b}\n" +
                              $"c = {c}\n" +
                              $"d = {d}\n" +
                              $"max = {max}");

        }

        private static int GetMax(int a, int b, int c, int d)
        {
            var maxAB = a>b?a:b;
            var maxCD = c>d?c:d;
            return maxAB > maxCD ? maxAB : maxCD;
        }
    }
}