using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSecurityList
{
    internal interface IThreadSecurityList<T>
    {
        public void Add(T item);
        public void RemoveByIndex(int index);
        public T GetByIndex(int index);
    }
}
