using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Taple_Nullable.Lessontasks
{
    public class Generic<T,K,U>
        where T:unmanaged
        where K:new()
        where U:class
    {
        public T a { get; set; }
        public T b { get; set; }
        public  void Add(T a1, T b1)
        {
            a1 = this.a;
            b1 = this.b;
            //Console.WriteLine(a1+b1);
        }

        public  Generic(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public Generic()
        {

        }
    }
    public class MyClass1
    {
        public int MyProperty { get; set; }
        public MyClass1() { }
    }
    public interface Iinterface
    {
        public void Inter()
        {
            Console.WriteLine("hhhhhh");
        }
    }
}
