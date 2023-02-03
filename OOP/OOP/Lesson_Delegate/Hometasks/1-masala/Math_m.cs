using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Delegate.Hometasks._1_masala
{
    delegate void Math_Delegate(int a, int b);
    internal class Math_m
    {
        public static void Start(int a, int b)
        {
            Math_Delegate delegate0;
            delegate0 = Sum;
            delegate0 += Substract;
            delegate0 += Multiply;
            delegate0 += Divide;
            delegate0.Invoke(a, b);
        }
        public static void Sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public static void Substract(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, (a / b));
        }
    }
}
