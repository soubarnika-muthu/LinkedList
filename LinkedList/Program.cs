using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of Linked List");
            //creating object for collection class linked list 
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.AddFirst(70);
            linkedList.AddFirst(30);
            linkedList.AddFirst(56);
            linkedList.DisplayList();
            Console.WriteLine( "Insertion at Last:" );
            MyLinkedList<int> linkedList1 = new MyLinkedList<int>();
            linkedList1.AddLast(56);
            linkedList1.AddLast(30);
            linkedList1.AddLast(70);
            linkedList.DisplayList();
            Console.Read();
        }
    }
}
