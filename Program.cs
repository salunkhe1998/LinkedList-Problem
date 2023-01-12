using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedListAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine();
            linkedList.InsertAtPerticularPosition(2, 40);
            linkedList.Display();
            Console.WriteLine();
            //linkedList.popEnd();
            //linkedList.Display();
            linkedList.MsTest(30);
            linkedList.Display();
            Console.ReadLine();
        }
    }
}