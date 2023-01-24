using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_10.uyga_vazifa_enum._3_masala_tg
{
    internal struct Laptop_Struct
    {
        public byte _RAM { get; init; }
        public int _memory { get; set; }
        public byte _CPU { get; init; }
        public string _model { get; init; }
        public Colors _color { get; init; }
        public void On()
        {
            Console.WriteLine("Computer burned");
        }
        public void Off()
        {
            Console.WriteLine("Computer turned off");
        }
        public void Restart()
        {
            Console.WriteLine("Computer rebooted");
        }

        public Laptop_Struct(byte rAM, int memory, byte cPU, string model, Colors color)
        {
            _RAM = rAM;
            _memory = memory;
            _CPU = cPU;
            _model = model;
            _color = color;
        }
    }
}
