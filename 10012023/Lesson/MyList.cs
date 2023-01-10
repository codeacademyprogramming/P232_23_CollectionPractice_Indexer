using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class MyList<T>:IEnumerable<T>
    {
        T[] _arr = new T[0];

        public void Add(T value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }

        public T this[int index]
        {
            get { return _arr[index]; }
            set
            {
                if (index >= _arr.Length)
                    Array.Resize(ref _arr, index+1);

                _arr[index] = value;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _arr)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in _arr)
                yield return item;
        }

    }
}
