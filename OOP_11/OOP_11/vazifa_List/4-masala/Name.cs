/*1)	Elementlarini alfabet tartibida joylashtiruvchi Ismlarni saqlovchi list yarating 
 * va uni 10 ta element bilan to’ldiring
2)	Ismlar joylashgan listdan “A” harfidan boshlangan ismlarni o’chiring.*/
namespace OOP_11.vazifa_List._4_masala
{
    internal class Name
    {
        public static void List_Name()
        {
            List<string> name = new List<string>
            {
            "Javlon",
            "Abror",
            "Komil",
            "Bexruz",
            "Ozod",
            "Asadbek",
            "Tohir",
            "Qosim",
            "Ulugbek",
            "Mehriddin"
            };
            name.Sort();
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
        public static void GetName()
        {
            
            Name.List_Name();
        }
    }
}
