﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
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
        public override void SortDesc(IMyList list)
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
            Console.WriteLine("InsertionSortDesc");
        }
    }
}
