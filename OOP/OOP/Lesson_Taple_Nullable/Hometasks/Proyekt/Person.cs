using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Taple_Nullable.Hometasks.Proyekt
{
    public class Person : IPerson<int>
    {
        public int Id { get; set; }
        public byte age { get; set; }
        public string name { get; set; }

        public Person(int id, byte age, string name)
        {
            Id = id;
            this.age = age;
            this.name = name;
        }
    }
}
