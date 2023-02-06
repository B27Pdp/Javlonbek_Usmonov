using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*CardTypeNotMatch(cartalar tiofasi mos bo’lmagan holat)*/
namespace OOP.Lesson_Event.Hometasks.Cards
{
    internal class CardTypeNotMatchEx : SystemException
    {
        public override string Message { get; } = "Cartalar tiofasi mos bo’lmagan holat";
    }
}
