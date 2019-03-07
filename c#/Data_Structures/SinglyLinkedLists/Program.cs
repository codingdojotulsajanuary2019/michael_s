using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList MyList = new SinglyLinkedList();
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
            MyList.Add(6);
            MyList.Add(7);
            MyList.Add(8);
            MyList.Add(9);
            MyList.Add(10);
            MyList.PrintValues();
            MyList.Remove();
            MyList.PrintValues();
        }
    }
}
