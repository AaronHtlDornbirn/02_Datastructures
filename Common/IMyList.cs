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
        void SortDesc();
    }
}