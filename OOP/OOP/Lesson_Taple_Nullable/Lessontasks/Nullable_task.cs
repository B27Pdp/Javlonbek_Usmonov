namespace OOP.Lesson_Taple_Nullable.Lessontasks
{
    public class Nullable_task
    {
        public static void Nullablee()
        {
            int? a = null;
            int? b = 5;
            int? c = b;
            //Console.WriteLine(c);
            a = a + b;
            Console.WriteLine(a);
            if (a is int) { Console.WriteLine(a); }
        }
        
    }
}
