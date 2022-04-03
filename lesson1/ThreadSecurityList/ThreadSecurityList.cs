using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSecurityList
{
    public class ThreadSecurityList<T> : IThreadSecurityList<T>
    {
        private IList<T> list;
        public ThreadSecurityList()
        {
            list = new List<T>();
        }
        public void Add(T item)
        {
            lock (list)
            {
                list.Add(item);
            }
        }

        public T GetByIndex(int index)
        {
            lock (list)
            {
                return list[index];
            }
        }

        public void RemoveByIndex(int index)
        {
            lock (list)
            {
                list.RemoveAt(index);
            }
        }
    }
}
