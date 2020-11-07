// 1. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.
using System;

namespace Lesson_1_Ex_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var height = 1.9f;
            var weight = 90;
            var weightIndex = GetWeightIndex(weight, height);
            Console.WriteLine(weightIndex);

        }

        public static float GetWeightIndex(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}