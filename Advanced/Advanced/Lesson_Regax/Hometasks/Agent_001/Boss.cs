using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Lesson_Regax.Hometasks.Agent_001
{
    public class Boss 
    {
        public event EventHandler<EventHandler> AgentStarted;
        public EventHandler Task;
        public void Agent_task()
        {
            Console.WriteLine("BOSS");
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);

            Others others= new();
            Task = others.Method1;
            Task += others.Method2;
            Task += others.Method3;

            AgentStarted.Invoke(this, Task);

        }
    }
}
