using System;
using System.Collections;
using System.Reflection;


class Collections
{
    static void Main(string[] args)
    {
        ArrayList myList = new ArrayList();
        ArrayList myList2 = new ArrayList() { 0, 10, "abc" };
        myList.InsertRange(0, myList2);
        myList.Add(10);

        //removeItems
        myList2.Remove(5);
        myList2.RemoveAt(0);
        Boolean deger = myList2.Contains(10);
        // Console.WriteLine(deger);

        ArrayList sayilar = new ArrayList() { 10, 5, 6, 60 };
        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }
       

        foreach (var item in myList2)
        {
            Console.WriteLine(item);
        }


    }
}