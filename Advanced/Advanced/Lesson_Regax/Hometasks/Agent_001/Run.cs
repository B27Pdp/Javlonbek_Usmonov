using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Lesson_Regax.Hometasks.Agent_001
{
    internal class Run
    {
        public static void Runn()
        {
            Boss boss = new();
            Josus josus = new();
            boss.AgentStarted += josus.Kill;
            boss.Agent_task();

        }
    }
}
