using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Berilgan matnning uzunligini aniqlaydigan method yarating.
 * Ushbu methoddan foydalangan holda Klaviaturadan kiritilgan matnning uzunligini ekranga chiqazadigan dastur tuzing. 
 * Agarda matn bo’sh bo’lsa ArgumentException throw qilinsin. Message sifatida “Kiritilgan matn bo’sh bo’lmasligi kerak” degan xabar bo’lsin. (Oson)*/
namespace OOP.Lesson_Event.Hometasks.Try_1
{
    internal class ExceptionLength
    {
        public static void String_Length(string str) 
        {
            try
            {
                if(str.Length== 0)
                {
                    throw new ArgumentMatchException();
                }
                Console.WriteLine(str.Length);
            }
            catch(ArgumentMatchException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
