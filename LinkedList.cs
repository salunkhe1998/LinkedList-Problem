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

        public Node InsertAtPerticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }

            }
            Console.WriteLine("\nInserted value is : " + data);
            return head;

        }

        public void pop()
        {
            if (head == null)
            {
                Console.Write("Stack is empty");
                return;
            }

            head = head.next;
            Console.WriteLine("\nFirst Element has been Deleted");

        }

        public void popEnd()
        {

            if (head == null)
            {
                Console.Write("linkedlist is empty");
                return;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                if (temp.next.next == null)
                {
                    temp.next = null;
                }
                Console.WriteLine("\nThe linkedlist is modified");
            }

        }

        public void MsTest(int x)
        {
            Node temp = head;

            while (temp != null)
            {

                if (temp.data == x)
                {
                    Console.WriteLine(temp.data + "==" + x + "(True)");
                }
                else
                {
                    Console.WriteLine(temp.data + "!=" + x);
                }
                temp = temp.next;
            }



        }


        public void Display()
        {
            Node temp = head; //temp variable is created.

            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            Console.WriteLine();
            //Console.WriteLine("Display Method is Executed");

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