using System;

namespace Quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, D, x1, x2;
            Console.WriteLine("Enter coefficient 'a'");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coefficient 'b'");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coefficient 'c'");
            c = Convert.ToDouble(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D >= 0 && a != 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("X1 =  X2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Корней нет");
            }

        }
    }
}
