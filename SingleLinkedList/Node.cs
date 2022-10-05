using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Node
    {
        public Object data;
        public Node next;

        public Node(Object _current) {
            data = _current; 
            next = null;
        }
    }
}