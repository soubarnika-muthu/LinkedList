using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        /// <summary>
        /// UC1-Creating simple Linked List 
        /// UC2- Method to add element in front
        /// UC3- Method to insert element at last. 
        /// UC4- Ability to add between two nodes
        /// UC5- Ability to delete first node
        /// UC6- Ability to delete last node
        /// UC7- Ability to search the Node
        ///  UC8 -Insert node using Test Cases
        ///  UC9 -Finding size of list
        ///  //UC10-Creating Sorted Linked list
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of Linked List");
            //creating object for collection class linked list 
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            while (true)
            {
                Console.WriteLine("\n\n*********Main Menu*********\n");
                Console.WriteLine("\nChoose one option from the following list ...\n");
                Console.WriteLine("\n===============================================\n");
                Console.WriteLine("\n1.Insert in begining\n2.Insert at last\n3.Insert at any random location\n4.Delete from Beginning\n "); 
                Console.WriteLine("5.Delete from last\n6.Search for an element\n7.Display\n8.Exit\n");

                Console.WriteLine("\nEnter your choice?\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insertion Elements at First");
                       
                        linkedList.AddFirst(70);
                        linkedList.AddFirst(30);
                        linkedList.AddFirst(56);
                        linkedList.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Insertion Elements at last");
                       // MyLinkedList<int> linkedList1 = new MyLinkedList<int>();
                         linkedList.AddLast(56);
                         linkedList.AddLast(30);
                         linkedList.AddLast(30);
                        linkedList.DisplayList();
                        break;
                     case 3:
                        Console.WriteLine("Insertion at Between Elements");
                      
                        linkedList.AddLast(56);
                        linkedList.InsertToNext(30, 56);
                        linkedList.InsertToNext(70, 56);
                        linkedList.DisplayList();
                        break;
                    case 4:
                        Console.WriteLine("Deleting Elements at first");
                        linkedList.DeleteFirst();
                        linkedList.DisplayList();
                        break;
                    case 5:
                        Console.WriteLine("Deleting Elements at last");
                        linkedList.DeleteLast();
                        linkedList.DisplayList();
                        break;
                    case 6:
                       // Console.WriteLine("Searching Elements ");
                        int result=linkedList.Search(30);
                        if(result==1)
                        {
                            Console.WriteLine("Element is present");
                        }
                        else
                        {
                            Console.WriteLine("Element not present");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice..");
                        break;
                }
            }
        }

        
       
    }
}
