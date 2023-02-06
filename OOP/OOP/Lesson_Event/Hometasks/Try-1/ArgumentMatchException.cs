using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Event.Hometasks.Try_1
{
    internal class ArgumentMatchException : SystemException
    {
        public override string Message { get; } = " kiritilgan matn bo’sh bo’lmasligi kerak";
    }
}
