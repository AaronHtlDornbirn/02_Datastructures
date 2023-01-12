using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class InsertionSortInverse : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.First().next;

            while (nextNode != null)
            {
                for (var current = list.First(); current.next != null; current = current.next)
                {
                    if (current == nextNode)
                        break;
                    if ((int)current.Data > (int)nextNode.Data)
                        continue;
                    (current.Data, nextNode.Data) = (nextNode.Data, current.Data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSortInverse");
        }

        public void SortDesc()
        {

        }

        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }
    }
}