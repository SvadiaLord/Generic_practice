using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_practice1.Core
{
    internal interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T Get(int Index);
        IRepository<T> GetAll(); 
    }
}
