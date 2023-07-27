using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какое задание вы хотите включить?: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.Write("Задание #1: \r\n\n"); /////////////////////////////////////////////////////////////////////


                double prov = 0;
                Console.Write("Введите число a: ");
                double a = Convert.ToInt32(Console.ReadLine());

                if (a == 0)
                {
                    Console.Write("a == 0");
                    System.Environment.Exit(1);
                }

                if (a > 0) prov++;

                Console.Write("Введите число b: ");
                double b = Convert.ToInt32(Console.ReadLine());

                if (b == 0)
                {
                    Console.Write("b == 0");
                    System.Environment.Exit(1);
                }

                if (b > 0) prov++;

                Console.Write("Введите число c: ");
                double c = Convert.ToInt32(Console.ReadLine());

                if (c == 0)
                {
                    Console.Write("c == 0");
                    System.Environment.Exit(1);
                }

                if (c > 0) prov++;

                if (prov == 2) Console.Write("true");
                else Console.Write("false");
            }

            if (number == 2)
            {
                Console.Write("\r\n\nЗадание #2: \r\n\n"); ///////////////////////////////////////////////////////////////////////////


                Console.Write("Введите координату x: ");
                double x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    Console.Write("x == 0");
                    System.Environment.Exit(1);
                }

                Console.Write("Введите координату y: ");
                double y = Convert.ToInt32(Console.ReadLine());
                if (y == 0)
                {
                    Console.Write("y == 0");
                    System.Environment.Exit(1);
                }

                if (x > 0 && y > 0) Console.Write("1 четверть");
                if (x > 0 && y < 0) Console.Write("4 четверть");
                if (x < 0 && y > 0) Console.Write("2 четверть");
                if (x < 0 && y < 0) Console.Write("3 четверть");
            }

            if(number == 3)
            {
            Console.Write("\r\n\nЗадание #3: \r\n\n"); //////////////////////////////////////////////////////////////////////////////////


            Console.Write("Введите вещественное число a: ");
            double A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите вещественное число b: ");
            double B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите вещественное число c: ");
            double C = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите вещественное число Xначальное: ");
            double firstx = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите вещественное число Xконечное: ");
            double secondx = Convert.ToInt32(Console.ReadLine());

            double fx = 0;

            Console.Write("Введите вещественное число deltaX: ");
            double dx = Convert.ToInt32(Console.ReadLine());

                for (double X = firstx; X <= secondx; X = X + dx)
                {
                    int v = 0;
                    if (C < 0 && A != 0)
                    {
                        v = 1;
                        fx = -A * X * X;
                    }
                    else if (C > 0 && A == 0)
                    {
                        v = 2;
                        if (X == 0)
                        {
                            Console.WriteLine("X=0 ДЕЛЕНИЕ НА НОЛЬ НЕВОЗМОЖНО!!!");
                            continue;
                        }
                        fx = (X - A) / (C * X);
                    }
                    else
                    {
                        v = 3;
                        if(C== 0)
                        {
                            Console.WriteLine("C=0 ДЕЛЕНИЕ НА НОЛЬ НЕВОЗМОЖНО!!!");
                            System.Environment.Exit(1);
                        }
                            
                        fx = X / C;
                    }

                    Console.WriteLine($"x={Math.Round(X, 2)} f(x)={Math.Round(fx)} (a={A} b={B} c={C} Var f(x)={v})");
                }
            }
        }

    }
}