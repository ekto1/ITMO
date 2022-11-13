using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblWorm.Bibl
{
    abstract class Item : IComparable
    {
        protected long invNumber; // инвентарный номер — целое число
        protected bool taken;    // хранит состояние объекта - взят ли на руки

        abstract public void Return();    // операция "вернуть"

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item()
        {
            taken = true;
        }

        public bool IsAvailable()    // истина, если этот предмет имеется в библиотеке
        {
            if (taken == true)
                return true;
            else
                return false;
        }

        public long GetInvNumber()   // инвентарный номер  
        {
            return invNumber;
        }


        private void Take()      // операция "взять"
        {
            taken = false;
        }

        public void TakeItem()
        {
            if (IsAvailable())
                Take();
        }


        public override string ToString()
        {
            if (taken)
                return "Состояние хранения: Инвентарный номер: " + invNumber + ". В наличии";
            else
                return "Состояние хранения: Инвентарный номер: " + invNumber + ". Нет в наличии";
        }


        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (invNumber == it.invNumber) return 0;
            else if (invNumber > it.invNumber) return 1;
            else return -1;
        }
    }
}
