using lab8._1;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    delegate void ProcessMagazineDelegate(Magazine mag, DateTime dt);
    class Magazine : Item, IPubs
    {
        public string Volume { get; set; } 
        public int Number { get; set; } 
        public string Title { get; set; }
        public int Year { get; set; }
        public bool IfSubs { get; set; }
        public static event ProcessMagazineDelegate Subscribe = null;
        public Magazine(string volume, int number, string title, int year,long invNumber, bool taken) : base(invNumber, taken)
        {
            this.Volume = volume;
            this.Number = number;
            this.Title = title;
            this.Year = year;
        }
        public Magazine(){ }

        public override string ToString()
        {
            string bs = String.Format("\nЖурнал:\n Том: {0}\n Номер:{1}\n Название: {2} \n Год выпуска: {3} \n Статус подписки: {4}", Volume, Number, Title, Year, IfSubs);
            return bs;
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }
        new public void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }
        public void Subs()
        {
            IfSubs = true;
            if (Subscribe != null)
                Subscribe(this, DateTime.Now);
        }
        public override void Return()
        {
            taken = true;
        }
    }   
}
