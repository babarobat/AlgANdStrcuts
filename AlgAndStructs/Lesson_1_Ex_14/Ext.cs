using System;


namespace Lesson_1_Ex_14
{
    public static class Ext
    {
        public static int Lenght(this int n)
        {
            var counter = 1;
           
            while (n.Abs() /10>0)
            {
                n = n / 10;
                counter++;
            }

            return counter;
        }
        public static int Lenght(this long n)
        {
            var counter = 1;
           
            while (n.Abs() /10>0)
            {
                n = n / 10;
                counter++;
            }

            return counter;
        }

        public static int Abs(this int input)
        {
            if (input == int.MinValue)
                throw new OverflowException(("Overflow_NegateTwosCompNum"));
            
            return input < 0 ? -input : input;  
        }
        public static long Abs(this long input)
        {
            if (input == long.MinValue)
                throw new OverflowException(("Overflow_NegateTwosCompNum"));
            
            return input < 0 ? -input : input;  
        }

        public static long PowerOf(this int input, uint power)
        {
            if (input == 0 ||power == 1)
                return input;
            if (power == 0)
                return 1;
            
            var result = (long)input;
            for (int i = 0; i < power-1; i++)
            {
                result *= input;
            }

            return result;
        }

    }
}