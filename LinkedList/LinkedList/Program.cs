using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Demo..");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2, 30);
            //list.RemoveFirstNode();
            list.RemoveLastNode();
            list.Display();
        }
    }
}
