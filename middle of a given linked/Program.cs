using System;

namespace middle_of_a_given_linked
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Add(6);

            linkedList.Print();
            linkedList.PrintMiddle();
        }
    }

    public class LinkedList
    {
        public Node head = null;
        public class Node
        {
            public int data;
            public Node link;
            public Node(int data)
            {
                this.data = data;
                link = null;
            }
        }

        public void Add(int data)
        {
            Node node = new Node(data);
            node.link = head;
            head = node;
        }

        public void Print()
        {
            Node temp = head;
            while (temp != null)
            { 
                Console.WriteLine(temp.data);
                temp = temp.link;
            }
        }

        public void PrintMiddle()
        {
            Node first_pointer = head;
            Node second_pointer = head;

            while (second_pointer != null && second_pointer.link != null)
            {
                first_pointer = first_pointer.link;
                second_pointer = second_pointer.link.link;
            }

            Console.WriteLine("Middle element is {0}", first_pointer.data);
        }
    }
}
