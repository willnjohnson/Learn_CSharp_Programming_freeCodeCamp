using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_Programming_freeCodeCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            [#001] Hello world
            
            Console.WriteLine("Hello world!");

            */

            /*
            [#002] Numeric data types

            Console.WriteLine($"Integers range from {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"Longs range from {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"Doubles range from {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"Floats range from {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"Decimals range from {decimal.MinValue} to {decimal.MaxValue}");

            int age = 27;
            Console.WriteLine(age);

            long bigNumber = 900_000_000L;
            Console.WriteLine(bigNumber);

            double negative = -55.2D;
            Console.WriteLine(negative);

            float precision = 5.000001F;
            Console.WriteLine(precision);

            decimal money = 14.99M;
            Console.WriteLine(money);

            int x = 10, y = 20, z = 30;

            */

            /*
            [#003] Text based data types

            string name = "William";
            char letter = 'W';

            Console.WriteLine($"My name is {name}");
            Console.WriteLine(letter);
            */

            /*
            [#004] Converting string to numbers

            int age = Convert.ToInt32("27"); // convert string 27 to int
            long bigNumber = Convert.ToInt64("900000000");
            double negative = Convert.ToDouble("-55.2");
            float precision = Convert.ToSingle("5.000001");
            decimal money = Convert.ToDecimal("14.99");
            Console.WriteLine(age);
            Console.WriteLine(bigNumber);
            Console.WriteLine(negative);
            Console.WriteLine(precision);
            Console.WriteLine(money);
            */

            /*
            [#005] Boolean data type

            bool isMale = true;
            Console.WriteLine(isMale);
            */

            /*
            [#006] Operators

            int age = 27;
            Console.WriteLine(++age); // increment then print
            Console.WriteLine(age); // print
            Console.WriteLine(age--); // print then decrement

            age += 1;
            age = age + 1;
            Console.WriteLine(age);

            age *= 10;
            Console.WriteLine(age);

            Console.WriteLine((Double) age / 3);

            char ch = 'a'; // U+0061
            ch += 'b'; // U+0062
            Console.WriteLine(ch); // U+00C3

            */

            Console.ReadLine();
}
}
}
