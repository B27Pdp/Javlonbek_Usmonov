using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Event.Hometasks
{
    delegate void HometasksEventHandlerjama(Jamshid? jama, Message sms);

    internal class Jamshid
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public event HometasksEventHandlerjama? Event_Jama;

        public void SendSMS(string str)
        {
            Message sms = new Message();
            sms.SMS = str;
            sms.data = DateTime.Now;
            Event_Jama.Invoke(this, sms);

        }
        public List<(string, string, string, DateTime)> messages = new();
        public void AddSMS(Javlon java, Message sms)
        {
            messages.Add((java.Name,java.Number,sms.SMS,sms.data));
        }
        public void GetSMS()
        {
            foreach (var item in messages)
            {
                Console.WriteLine(  item);
            }
        }
        public Jamshid(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}
