using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SortNode<T>
    {
        public T value;
        public SortNode<T> Next;

        public SortNode(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    public class SortedLinkedList<T> where T : IComparable
    {
        public SortNode<T> head;

        public void AddFirst(SortNode<T> newNode)
        {

            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            //make ne element as head
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }


        //method to insert newNode next to existing nod

        public void CreateSortList(T value)
        {
            SortNode<T> sortNode = new SortNode<T>(value);
            //if the list is empty then add first
            if (head == null)
            {
                AddFirst(sortNode);
            }
            //else if first element is greater than current element then push front
            else if (head.value.CompareTo(value) >= 0)
            {
                AddFirst(sortNode);
            }

            //find the position before the maximum element then push the current element at the particular position
            else
            {
                SortNode<T> temp = head;
                SortNode<T> prev = head;
                while (temp.Next != null && temp.Next.value.CompareTo(value) < 0)
                {
                    prev = temp;
                    temp = temp.Next;
                }
                if (temp.Next == null)
                {
                    temp.Next = sortNode;
                }
                else if (temp.Next.value.CompareTo(value) > 0)
                {
                    sortNode.Next = temp.Next;
                    temp.Next = sortNode;
                }
            }

        }
        public void DisplayList()
        {
            SortNode<T> temp = head;
            //if head is null then no element is present
            if (head == null)
            {
                Console.WriteLine("No element in the list");
            }
            //else until temp become null print the elements 
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("" + temp.value);
                    temp = temp.Next;
                }
            }
        }



    }
}
