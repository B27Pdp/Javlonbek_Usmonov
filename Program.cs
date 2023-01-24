using System.Runtime.CompilerServices;
using OOP_10.uyga_vazifa_enum;
using OOP_10.uyga_vazifa_enum._2_masala_sayt;
namespace OOP_10.uyga_vazifa_enum._3_masala_tg
{
    class Program
    {
        public static void Main(string[] args)
        {
            Weekend day = new Weekend();
            day.IsWeekend();
            Color.GetColorIndex();
            Laptop_Class hp = new(16, 256, 4, "probook", Colors.Gray);
            
            Laptop_Struct hp1 = new(16, 256, 4, "probook", Colors.Gray);
            
            Laptop_Record hp2 = new(16, 256, 4, "probook", Colors.Gray);

            Console.WriteLine(hp2);

            /*Console.WriteLine(GenericClass<string>.Metod("Salom ","dunyo"));
            Console.WriteLine(GenericClass<int>.Metod(5,6));
            Console.WriteLine(GenericClass<double>.Metod(5.8,6.4));*/
            GenericClass<int, string> obj = new(8,"javlon");
            
        }
    }
}

