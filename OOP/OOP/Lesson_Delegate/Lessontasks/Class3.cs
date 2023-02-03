using System;
using System.Reflection.Metadata;

namespace OOP.Lesson_Delegate.Lessontasks
{
    delegate bool Class3_delegate1(Class3_delegate2 _Delegate, string str);
    delegate bool Class3_delegate2(int n);
    internal class Class3
    {
        static Class3_delegate1 delegate1 = Print1;
        static Class3_delegate2 delegate2 = Print2;
        
        
        
        public static bool Print1(Class3_delegate2 delegate0, string s)
        {
            Console.WriteLine("Print1();  "+ s);
            return true;

        }
        public static bool Print2(int n)
        {
            delegate1(delegate2, "Hello");
            Console.WriteLine("Print2();"+n);
            return true;

        }

    }
}
