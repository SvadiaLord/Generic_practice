using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_practice1.Core
{
    internal class ClassMassiv<T>
    {
        private T element;

        public void Swap<T>(T[] array, int Index1, int Index2)
        {
            if (Index1 < 0 || Index1 >= array.Length || Index2 < 0 || Index2 >= array.Length)
            {
                throw new ArgumentOutOfRangeException("Индекс вне диапазона массива.");
            }
            T peremennaya = array[Index1];
            array[Index1] = array[Index2];
            array[Index2] = peremennaya;

        }
    }
}
