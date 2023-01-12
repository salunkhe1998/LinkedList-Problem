using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    public class LinkedList
    {
        public Node head;

        public void Add(int value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }

            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine("{0} is inserted in Linked List.", value);
        }


        public void Display()
        {
            Node temp = head; //temp variable is created.

            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            Console.WriteLine();
            Console.WriteLine("Display Method is Executed");

            while (temp != null)
            {

                Console.Write(temp.data + " ");

                temp = temp.next;

                if (temp != null)
                {
                    Console.Write("->");
                }
            }

        }
    }
}