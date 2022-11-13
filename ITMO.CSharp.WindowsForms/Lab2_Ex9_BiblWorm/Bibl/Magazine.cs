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
            IfSubs = true; // действия при оформлении подписки на журнал
        }


        public override string ToString()
        {
            if (IfSubs)
                return "\nЖурнал:\nНазвание: " + title + "\nТом: " + volume +
                "\nНомер: " + number + "\nГод выпуска: " + year + "\nПодписка оформлена";
            else
                return "\nЖурнал:\nНазвание: " + title + "\nТом: " + volume +
            "\nНомер: " + number + "\nГод выпуска: " + year + "\nПодписка не оформлена";
        }
    }
}
