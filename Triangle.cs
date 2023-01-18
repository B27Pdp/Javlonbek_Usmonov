namespace OOP_9
{
    internal class Triangle
    {
        public int a;
        public int b;
        public int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle() { }
        public void GetABC() { Console.WriteLine($"{a} {b} {c}"); }
        public static Triangle operator -(Triangle x)
        {
            x.a = 2 * x.a;
            x.b = 2 * x.b;
            x.c = 2 * x.c;
            return x;
        }
    }
    
}
