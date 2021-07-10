﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   //Creation of NewNode
        public class Node<T>
        {
            public T value;
            public Node<T> Next;
            public Node(T value)
            {
                this.value = value;
                this.Next = null;
            }
        }
        class MyLinkedList<T>
        {
            private Node<T> head;

            //method to insert the element in front;
            public void AddFirst(T value)
            {
                //creating the new node with given value
                Node<T> newNode = new Node<T>(value);
                //check whether the head is null or not . 
                if (head == null)
                {
                    head = newNode;
                }
                //make new element as head
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }
            }
        public void AddLast(T value)
        {
            //creating the new node with given value
            Node<T> newNode = new Node<T>(value);
            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            //iterate till the last element and make next feild of last element as newNode
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        //method to insert newNode next to existing node
        public void InsertToNext(T value, T nextValue)
        {
            //creating the new node with given value
            Node<T> newNode = new Node<T>(value);
            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            //iterate till the last element or till the node is found
            else
            {
                //initialize two local variable to hold the node address
                Node<T> prev = head;
                Node<T> temp = prev.Next;
                while (prev.Next != null && !(prev.value.Equals(nextValue)))
                {
                    prev = temp;
                    temp = temp.Next;
                }
                if (prev.value.Equals(nextValue))
                {
                    newNode.Next = prev.Next;
                    prev.Next = newNode;
                }
                else
                {
                    Console.WriteLine("Element {0} is not found.\nElement{1} is added at last", nextValue, value);
                    prev.Next = newNode;
                }
            }
        }
        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("No element in the list");
            }
            //make the next node as head
            else
            {
                head = head.Next;
            }
        }

        //method to display the element 
        public void DisplayList()
            {
                Node<T> temp = head;
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

