using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<KeyValuePair<object, object>, object> want = new KeyValuePair<KeyValuePair<object, object>, object>();
            MyCollection<KeyValuePair<object, object>, string> col = new MyCollection<KeyValuePair<object, object>, string>();

            UserType zn1=new UserType(312, "zn1"), zn2=new UserType(444, "zn2"), zn3 = new UserType(444, "zn3");

            col.Add(new KeyValuePair<object, object>("Anna", 123), "first");
            col.Add(new KeyValuePair<object, object>("Ben", 321), "second");
            col.Add(new KeyValuePair<object, object>("Oleg", 312), "thrid");
            col.Add(new KeyValuePair<object, object>("Tod", 312), "fourth");
            col.Add(new KeyValuePair<object, object>("Jane", 555), "fifth");

            want = col.GetElement(new KeyValuePair<object, object>("Anna", 123));

            foreach (var i in col)
            {
                Console.WriteLine("Id={0}; Name={1}; Value={2}", i.Key.Key, i.Key.Value, i.Value);
            }
            Console.WriteLine();

            col.Remove(new KeyValuePair<object, object>("Anna",123));
            col.Remove(false, "Ben");
            col.Remove(true, 312);

            foreach (var i in col)
            {
                Console.WriteLine("Id={0}; Name={1}; Value={2}", i.Key.Key, i.Key.Value, i.Value);
            }
            Console.WriteLine();

            col.Add(want.Key,want.Value);
            col.Add(new KeyValuePair<object, object>(zn1, zn2), "test");
            col.Add(new KeyValuePair<object, object>(zn1, zn3), "test2");
            want = col.GetElement(new KeyValuePair<object, object>(zn1, zn2));
            
            foreach (var i in col)
            {
                Console.WriteLine("Id={0}; Name={1}; Value={2}", i.Key.Key, i.Key.Value, i.Value);
            }

            Console.ReadLine();

        }
    }
}
//Спасибо за интересное задание, в любом случае было познавательно
//Курбатов Е.И