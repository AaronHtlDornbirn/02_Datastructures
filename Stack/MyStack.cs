using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Stack
{
    public class MyStack
    {
        private SingleLinkedList.SingleLinkedList myStack = new SingleLinkedList.SingleLinkedList();
        public object Push(object value)
        {
            myStack.InsertLast(value);
            return value;
        }

        public Node Pop()
        {
            var nodeToDelete = myStack.Last();
            myStack.DeleteNode(nodeToDelete);
            return nodeToDelete;
        }

        public override string ToString()
        {
            return myStack.ToString();
        }
    }
}