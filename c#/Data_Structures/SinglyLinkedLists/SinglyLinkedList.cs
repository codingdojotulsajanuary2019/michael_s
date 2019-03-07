using System;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList() 
        {
            // your code here
            Head = null;

        }
        // SLL methods go here. As a starter, we will show you how to add a node to the list.
        public void Add(int value) 
        {
            SllNode runner = Head;
            SllNode newNode = new SllNode(value);
            if(Head == null) 
                {
                    Head = newNode;
                } 
            else
            {
                while(runner.Next != null)
                {
                runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }

        public void Remove()
        {
            if(Head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                SllNode runner = Head;
                while(runner.Next.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = null;

            }
        }

        public void PrintValues()
        {
            if(Head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                SllNode runner = Head;
                while(runner != null)
                {
                    Console.WriteLine(runner.Value);
                    runner = runner.Next;
                }
            }
        }


    }    
}

