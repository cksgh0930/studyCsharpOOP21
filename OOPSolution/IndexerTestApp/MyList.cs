using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;

        public int this[int index] // == Mylist[i] = array[i]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >=array.Length) //하나씩 증가
                {
                    System.Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; } //3
        }

        public object Current => throw new NotImplementedException();

        public MyList()
        {
            array = new int[3];
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
