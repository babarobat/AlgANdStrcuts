// 3. Написать программу обмена значениями двух целочисленных переменных:
// a. с использованием третьей переменной;
// b. *без использования третьей переменной.

using System;

namespace Lesson_1_Ex_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var a = random.Next(-1000,1000);
            var b = random.Next(-1000,1000);
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine("Swap!");
            Swap(ref a,ref b);
            Console.WriteLine($"a = {a}, b = {b}");
            
        }

        private static void  Swap(ref int a,ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            
        }
        
    }
}