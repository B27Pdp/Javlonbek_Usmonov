using OOP.Lesson_Event.Hometasks;
using OOP.Lesson_Event.Hometasks._2_masala;
using OOP.Lesson_Event.Hometasks.Cards;
using OOP.Lesson_Event.Hometasks.Try_1;
using OOP.Lesson_Event.Lessontasks;

namespace OOP.Lesson_Event
{
    internal class Event_Main
    {
        public static void Mainn()
        {
            /*Yer yer1 = new();
            yer1.Name = "javlon";
            Oy oy1 = new();
            oy1.Name = ("Jamshid");
            Console.WriteLine("qayerdan qayerga sms yubormoqchisz : ");
            Console.WriteLine("1. Yerdan --> Oyga");
            Console.WriteLine("2. Oydan --> Yerga");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        yer1.Event_del += oy1.AddSms;
                        yer1.SendSms();
                        oy1.GetSms();
                        break;
                    }
                case 2:
                    {
                        oy1.Oy_Event += yer1.AddSms;
                        oy1.SendSMS();
                        yer1.GetSms();
                        break;
                    }
            }*/
            /*Jamshid jama = new("jamshid", "901234567");
            Javlon java = new("javlon","903409342");
            java.Event_Java += jama.AddSMS;
            java.SendSMS("qarshiliklar bormi");
            jama.GetSMS();
            //java.Event_Java -= jama.AddSMS;
            for (int i = 0; i < 100000; i++)
            {
                Console.Write(i);
            }
            jama.Event_Jama += java.AddSMS;
            jama.SendSMS("buxoroliklar bormi");
            java.GetSMS();
            jama.Event_Jama -= java.AddSMS;*/

            /*TryCatch a= new TryCatch();
            a.Run();*/

            /*JuftEvevt obj1= new JuftEvevt();
            PrintList obj2= new PrintList();
            obj1.Event_Juft += obj2.Print;
            obj1.Juft_N(new List<int> { 1, 2,3,4,5,6,7,8,9 });*/

            //ExceptionLength.String_Length("");

            #region [Card]
            Card uzcard = new(100000, CardTypes.UZCARD, Values.UZS);
            Card humo = new(100000, CardTypes.HUMO, Values.UZS);
            Card visa = new(100000, CardTypes.VISA, Values.USD);
            Card unionpay = new(100000, CardTypes.UNIONPAY, Values.USD);

            try
            {
                uzcard.SendMoney(humo, 1000);
            }
            catch (CardTypeNotMatchEx c)
            {
                Console.WriteLine(c.Message);
            }
            catch (NotEnoughMoneyEx c)
            {
                Console.WriteLine(c.Message);
            }


            #endregion

        }
    }
}
