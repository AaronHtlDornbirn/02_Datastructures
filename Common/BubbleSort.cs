using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BubbleSort : SortStrategy
    {

        public override void Sort(IMyList list)
        {
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                for (var current = list.First(); current.next != null; current = current.next)
                {
                    if (current.next == null)
                        continue;
                    else if ((int)current.Data > (int)current.next.Data)
                    {
                        (current.Data, current.next.Data) = (current.next.Data, current.Data);
                        sorted = false;
                    }
                }
            }
        }
        public override void SortDesc(IMyList list)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (var current = list.First(); current.next != null; current = current.next)
                {
                    if (current.next == null)
                        break;
                    if ((int)current.Data < (int)current.next.Data)
                    {
                        (current.Data, current.next.Data) = (current.next.Data, current.Data);
                        sorted = false;
                    }
                }
            }
        }
    }
}