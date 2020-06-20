using lab8._1;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {            
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            b2.SetPrice(5);
            b2.TakeItem(); 
            b2.Print();
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014,1235, true);
            Audit.RunAudit();
            mag1.TakeItem();
            mag1.Subs();
            mag1.Print();
            Audit.StopAudit();
            Console.WriteLine("\n Тестирование полиморфизма");
            Item it;
            it = b2;
            it.Return();
            it.Print();
            it = mag1;
            it.Return();
            it.Print();
            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b2, mag1 });
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach(Item x in itlist)
            {
                x.Print();
            }

        }
    }
}
