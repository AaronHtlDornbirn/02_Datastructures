using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common;

namespace SingleLinkedList
{
    public class SingleLinkedList : IMyList
    {
        public Node head;
        private SortStrategy sortStrategy;

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

        public Node First()
        {
            return head;
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

        public void InsertionSort()
        {
            Node currentNode = head.next;
            while (currentNode != null)
            {
                for (var current = head; current != null; current = current.next)
                {
                    if (current == currentNode)
                        break;
                    if ((int)current.Data < (int)currentNode.Data)
                        continue;
                    (current.Data, currentNode.Data) = (currentNode.Data, current.Data);
                }
                currentNode = currentNode.next;
            }
        }

        public void InsertionSortInverse()
        {
            Node currentNode = head.next;
            while (currentNode != null)
            {
                for (var current = head; current != null; current = current.next)
                {
                    if (current == currentNode)
                        break;
                    if ((int)current.Data > (int)currentNode.Data)
                        continue;
                    (current.Data, currentNode.Data) = (currentNode.Data, current.Data);
                }
                currentNode = currentNode.next;
            }
        }
        public void SetSortStrategy(SortStrategy _sortStrategy)
        {
            sortStrategy = _sortStrategy;
        }

        public void Sort()
        {
            sortStrategy.Sort(this);
        }

        public override string ToString()
        {
            string retval = "";
            if (head == null)
                return "No elements in List";

            var node = head;
            while (node != null)
            {
                retval += "| " + node.Data + " ";
                node = node.next;
            }
            retval += "|";
            return retval;
        }
    }
}