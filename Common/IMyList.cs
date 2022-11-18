using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IMyList
    {
        void SetSortStrategy(SortStrategy sortStrategy);
        Node First();
        void Sort();
    }

    public abstract class SortStrategy
    {
        public abstract void Sort(IMyList list);
    }

    public class InsertionSort : SortStrategy
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
                    if ((int)current.Data < (int)nextNode.Data)
                        continue;
                    (current.Data, nextNode.Data) = (nextNode.Data, current.Data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSort");
        }
    }

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
    }
}
