﻿namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 7;
            //int y = 2;
            //int result = x + y;

            //Console.WriteLine("Add: " + result);

            //result = x - y;

            //Console.WriteLine("Add: " + result);

            //result = x * y;

            //Console.WriteLine("Multi: " + result);

            //result = x / y;

            //Console.WriteLine("Gayofa: " + result);

            //result = x % y;

            //Console.WriteLine("nashti: " + result);

            // davaleba savarjishoi

            int x, y;
            int add, sub, mult, rem;
            float divide;

            Console.WriteLine("Enter no. 1 ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter no. 2 ");
            y = int.Parse(Console.ReadLine());

            add = x + y;
            Console.WriteLine(x + " + " + y + " = " + add);

            sub = x - y;
            Console.WriteLine(x + " - " + y + " = " + sub);

            mult = x * y;
            Console.WriteLine(x + " * " + y + " = " + mult);

            divide = (float)x / (float)y;,v bnnhuyhj
            Console.WriteLine(x + " / " + y + " = " + divide);

            rem = x % y;
            Console.WriteLine(x + " % " + y + " = " + rem);


        }
    }
}