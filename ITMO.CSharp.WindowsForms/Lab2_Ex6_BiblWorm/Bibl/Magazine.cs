using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblWorm.Bibl
{
    class Magazine : Item, IPubs
    {
        private string volume;    // том
        private int number;        // номер
        private string title;       // название
        private int year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(string volume, int number, string title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


        public override void Return()    // операция "вернуть"
        {
            taken = true;
        }

        // реализация интерфейса



        public void Subs()
        {
            // действия при оформлении подписки на журнал
        }


        public override string ToString()
        {
            if (IfSubs)
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
                "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
            else
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
            "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
        }
    }
}
