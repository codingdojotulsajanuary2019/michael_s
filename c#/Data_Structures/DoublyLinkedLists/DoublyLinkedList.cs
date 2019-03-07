using System;

namespace DoublyLinkedLists
{
    public class DoublyLinkedList
        {
            public DllNode Head;
            // Place your methods here.

            public void Add(int val)
            {
                DllNode NewNode = new DllNode(val);
                DllNode runner = this.Head;

                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = NewNode;
            }
    
        }

}