using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Lesson_Regax.Hometasks.Agent_001
{
    public class Josus
    {
        public void Kill(object sender, EventHandler Tasks)
        {
            Console.WriteLine("kill");
            Tasks.Invoke(sender, new EventArgs());
        }
    }
}
