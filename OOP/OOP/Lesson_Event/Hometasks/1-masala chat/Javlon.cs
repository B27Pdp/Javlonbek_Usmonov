using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Event.Hometasks
{
    delegate void HometasksEventHandler(Javlon java, Message sms);
    internal class Javlon
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public event HometasksEventHandler? Event_Java;
        public void SendSMS(string str)
        {
            Message sms= new Message();
            sms.SMS = str;
            sms.data=DateTime.Now;
            Event_Java.Invoke(this, sms);

        }
        public List<(string, string, string, DateTime)> messages = new();
        public void AddSMS(Jamshid jama, Message sms)
        {
            messages.Add((jama.Name, jama.Number, sms.SMS, sms.data));
        }
        public void GetSMS()
        {
            foreach (var item in messages)
            {
                Console.WriteLine(item);
            }
        }
        public Javlon(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}
