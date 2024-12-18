using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_practice1.Core
{
    internal class ClassAreEqual<T>
    {
        private T obj;

        public void AreEqual<T>(T[] array, bool obj1, bool obj2)
        {
            if (obj1 == obj2)
            {
                Console.WriteLine("Объекты равны");
            }
            else
            {
                Console.WriteLine("Объекты не равны");
            }
        }
    }
}
