using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Event.Hometasks.Cards
{
    internal class NotEnoughMoneyEx : SystemException
    {
        public override string Message { get; } = "pul yetarli bo’lmagan holat";
    }
}
