﻿using System;
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
            //linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();

            linkedList.InsertAtPerticularPosition(2, 30);
            linkedList.Display();
            linkedList.pop();
            linkedList.Display();
            Console.ReadLine();

        }
    }
}
Footer
© 2023 GitHub, Inc.