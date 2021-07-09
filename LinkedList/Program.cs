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
            LinkedList<int> linkedList = new LinkedList<int>();
           
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            foreach (int i in linkedList)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
