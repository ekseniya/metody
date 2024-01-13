using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            void Step(double A, double K, out double result)
            {
                result = 1;
                for (int i = 1; i <= K; i++)
                {
                    result *= A;
                }
            }
            void F(double nn, out double X)
            {
                X = 1;
                for (int i = 1; i <= nn; i++)
                {
                    X = X * i;
                }
            }
            Console.Write("n=");
            double n = double.Parse(Console.ReadLine());
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Step(x - y, n, out double s1);
            Step(a - b, n, out double s2);
            F(n + 3, out double p1);
            F(n, out double p2);

            double V = (s1 - p1) / (s2 - p2);
            Console.WriteLine($"V={V}");
        }
    }
}