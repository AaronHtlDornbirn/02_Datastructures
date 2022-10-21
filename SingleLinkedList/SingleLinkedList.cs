using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class SingleLinkedList
    {
        private Node head;
        
        public void printAllNodes()
        {
            Node current = head;
            String printString = "";
            while (current != null)
            {
                printString += current.Data + "\n";
                current = current.next;
            }
            Console.WriteLine(printString);
        }

        public void InsertFirst(object data)
        {
            head = new Node(data, head);
        }

        public void InsertLast(object data)
        {
            Node node = new Node(data, null);

            if (head == null)
            { 
                head = node;
            }
            else
            {
                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
        }

        public void InsertAfter(object data, int position)
        {
            if (position == 0)
            {
                InsertFirst(data);
                return;
            }
            int count = 0;
            Node current = head;
            while (count < position - 1)
            {

                if (current.next == null)
                {
                    Console.WriteLine(count + " doesn't exist");
                    return;
                }
                current = current.next;
                count++;
            }
            Node node = new Node(data, current?.next);
            current.next = node;
        }

        public Node GetNode(object data)
        {
            Node current = head;

            while (!current.Data.Equals(data))
            {
                if (current.next == null)
                {
                    return null;
                }
                current = current.next;
            }
            return current;
        }

        public bool DeleteNode(object argData)
        {
            Node current = head;
            Node previous = head;
            while (!current.Data.Equals(argData))
            {
                if (current.next == null)
                {
                    return false;
                }
                previous = current;
                current = current.next;
            }
            previous.next = current.next ?? null;
            return true;
        }

        public int Count()
        {
        Node node = head;

            int count = 0;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }
    }   
}