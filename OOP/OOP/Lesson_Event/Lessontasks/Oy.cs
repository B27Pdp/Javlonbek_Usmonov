using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Event.Lessontasks
{
    delegate void Oy_Delegate(string? sender, string sms);
    internal class Oy
    {
        public string? Name;
        public event Oy_Delegate? Oy_Event;
        public List<(object?, string)> list = new List<(object?, string)> ();
        public void GetSms()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void AddSms(object? obj, string sms)
        {
            list.Add((obj, sms));
        }

        public void SendSMS()
        {
            string? str;
            Console.Write("SMS kiriting : ");
            str = Console.ReadLine() ?? "no text";
            Oy_Event?.Invoke(Name, str);
        }
    }
}
