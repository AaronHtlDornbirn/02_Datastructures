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
        public int index = 0;
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

        public Node GetFirst()
        {
            return head;
        }

        public Node GetLast()
        {
            for (var cur = head; cur != null; cur = cur.next)
            {
                if (cur.next == null)
                    return cur;
            }
            return null;
        }

        public void DeleteFirst()
        {
            head = head.next;
        }

        public void DeleteLast()
        {
            var cur = head;
            while (cur.next != null)
            {
                if (cur.next.next == null)
                {
                    cur.next = null;
                    break;
                };
                cur = cur.next;
            }
        }


        public void InsertFirst(Object data)
        {
            if (head == null)
            {
                head = new Node(data, null);
                index++;
            }
            else
            {
                Node node = new Node(data, null);
                node.next = head;
                head = node;
                index++;
            }
        }

        public void InsertLast(Object data)
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

        public void DeleteAt(int _index)
        {
            if (_index > index)
            {
                Console.WriteLine("this Object doesn't exist");
            }
            else
            {
                Node previous = head;
                Node _next;

                for (int i = 0; i < _index; i++)
                {
                    previous = previous.next;
                }
                _next = previous.next.next;
                previous.next = _next;

            }
        }

        public void InsertAt(Object data, int _index)
        {
            if (_index > index)
            {
                Console.WriteLine("this Object doesn't exist");
            }
            else
            {
                Node previous = head;
                Node _next;

                for (int i = 0; i < _index; i++)
                {
                    previous = previous.next;
                }
                Node newNode = new Node(data, null);
                _next = previous.next;
                previous.next = newNode;
                newNode.next = _next;
                index++;
            }
        }

        public Node First()
        {
            return head;
        }

        public Node Last()
        {
            Node last = head;

            while (last.next != null)
            {
                last = last.next;
            }
            return last;
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
        public Node GetElement(Object element)
        {
            Node current = head;

            while (!current.Data.Equals(element))
            {
                if (current.next == null)
                {
                    Node node = new Node(element, null);
                    return node;
                }

                current = current.next;
            }
            return current;
        }

        public void InsertAfter(Object before, Object value)
        {
            Node node = new Node(value, null);
            Node getElement = GetElement(before);
            Node after = getElement.next;

            getElement.next = node;
            getElement.next.next = after;
        }
        public bool DeleteNode(Node node)
        {
            Node current = head;
            Node next;
            int index = 0;

            while (!current.Data.Equals(node.Data))
            {
                if (current.next == null)
                {
                    return false;
                }
                current = current.next;
            }

            index++;
            DeleteAt(index);

            return true;
        }

        public bool Exists(Node node)
        {
            Node currentNode = head;
            if (currentNode == node) return true;
            while (currentNode != node)
            {

                if (currentNode.next == node)
                {
                    return true;
                }
                currentNode = currentNode.next;
            }
            return false;
        }

        public void SwitchNodes(Node node1, Node node2)
        {
            if (!Exists(node1) || !Exists(node2)) return;

            (node1.Data, node2.Data) = (node2.Data, node1.Data);
        }

        public void RandomSort() //wrong
        {
            Node current = head;
            int node1 = int.Parse(string.Format("{0}", current.Data));
            int node2 = int.Parse(string.Format("{0}", current.next.Data));

            while (current != null)
            {
                if (current.next == null) return;
                if (node1 > node2)
                {
                    current.Data = node2;
                    current.next.Data = node1;
                    current = head;
                }
                current = current.next;
                if (current.next == null) return;
                node1 = int.Parse(string.Format("{0}", current.Data));
                node2 = int.Parse(string.Format("{0}", current.next.Data));
            }
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

        public void SortDesc()
        {
            sortStrategy.SortDesc(this);
        }
    }
}
