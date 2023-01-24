/*MONDAY, TUESDAY, WEDNESDAY... qiymatlarini o'z ichiga olgan WeekDay nomli enum toifasini va IsWeekend() metodini hosil qiling.
Foydalanuvchi console oynasi orqali hafta kunini kiritgan paytda, 
kiritilgan kun raqami haftaning dam olish kunlaridan biri yoki yo'qligini IsWeekend() metodi orqali aniqlang.*/
namespace OOP_10.uyga_vazifa_enum
{
    internal class Weekend
    {
        public byte _day_n;
        
        public void IsWeekend()
        {
            if (_day_n == 6 || _day_n == 7)
            {
                Console.Write((IsWeekend1)_day_n - 1);
                Console.WriteLine(" --> dam olish kuni");
            }
            else
            {
                Console.Write((IsWeekend1)_day_n - 1);
                Console.WriteLine(" --> dam olish kuni emas");
            }
        }

        public Weekend()
        {
            byte n;
            Console.Write("Hafta kunini kiriting : ");
            n =byte.Parse(Console.ReadLine());
            _day_n = n;
        }
    }
    enum IsWeekend1
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
}
