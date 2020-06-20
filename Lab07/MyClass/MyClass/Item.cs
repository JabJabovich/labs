using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    abstract class Item
    {
        protected long invNumber;
        protected bool taken;

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        public long GetInvNumber()
        {
            return invNumber;
        }
        protected void Take()
        {
            taken = false;
        }
        public abstract void Return();
        public void Print()
        {
            Console.WriteLine("Состояние единицы хранения:\n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
}
    }
}
