using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Node
    {
        public Object Data { get; set; }
        public Node next;

        public Node(Object data, Node _next)
        {
            next = _next;
            Data = data;
        }
    }
}