using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*```Card class(Id, Owner, Balance va CardType) va CardType enum(UZCARD, HUMO,VISA, UNIONPAY) toifalarini yarating. 
 * Ularga mos ravishda cutom CardTypeNotMatch(cartalar tiofasi mos bo’lmagan holat) 
 * va NotEnoughMoney(pul yetarli bo’lmagan holat) exceptionlari orqali  kartadan kartaga pul o’tkazuvchi dastur tuzing.
 * Uzcard va humo kartalari pul birligi so’m hamda Visa va
 * Unionpay kartalari pul birligi dollar. Pul birligi bir xil bo’lgan kartalardan bir-biriga pul o’tkazish tartibi o’rnatilgan. 
 * Agarda bunday tartibdan boshqa tarzda pul o’tkazishga urinish bo’lsa CardTypeNotMatch exceptioni chaqirilsin.
 * Agarda hisobdagi pul ko’chirilayotgan summadan kam bo’lsa NotEnoughMoney exceptioni chaqirilsin.```*/
namespace OOP.Lesson_Event.Hometasks.Cards
{
    internal class Card
    {
        public int Id { get; set; }
        public string? Owner { get; set; }
        public double Balance { get; set; }
        public  CardTypes Card_Type { get; set; }
        public Values typevalue { get; set; }

        public void SendMoney(Card card, double money) 
        {
            if (this.Balance < money)
            {
                throw new NotEnoughMoneyEx();
            }
            else if (this.typevalue != card.typevalue)
            {
                throw new CardTypeNotMatchEx(); 
            }
            else
            {
                card.Balance += money;
            }
        }

        public Card(double balance, CardTypes card_Type, Values typevalue)
        {
            Balance = balance;
            Card_Type = card_Type;
            this.typevalue = typevalue;
        }
    }
}
