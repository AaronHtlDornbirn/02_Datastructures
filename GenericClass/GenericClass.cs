using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericList<T>
    {
        private List<T> List = new List<T>();
        public void Add(T input)
        {
            List.Add(input);
        }

        public List<T> GetList()
        {
            return List;
        }

        public T GetList(int index)
        {
            return List.ElementAtOrDefault(index);
        }
    }
}