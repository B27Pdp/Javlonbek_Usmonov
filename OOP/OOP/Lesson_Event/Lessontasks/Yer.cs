using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Event.Lessontasks
{
    delegate void Event_delegate(string? obj, string sms);
    internal class Yer
    {
        public string? Name;
        public event Event_delegate? Event_del;
        public void SendSms()
        {
            string? str;
            Console.Write("SMS kiriting : ");
            str = Console.ReadLine() ?? "no text";
            Event_del?.Invoke(Name, str);
        }
        public List<(object?, string)> list = new List<(object?, string)>();
        public void GetSms()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void AddSms(string? obj, string sms)
        {
            list.Add((obj, sms));
        }
    }
}
