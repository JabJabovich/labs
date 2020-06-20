﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Magazine : Item
    {
        public string Volume { get; set; } 
        public int Number { get; set; } 
        public string Title { get; set; }
        public int Year { get; set; }
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
            string bs = String.Format("\nЖурнал:\n Том: {0}\n Номер: {1}\nНазвание: {2} \n Год выпуска: {3}", Volume, Number, Title, Year);
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
        public override void Return()
        {
            taken = true;
        }
    }   
}
