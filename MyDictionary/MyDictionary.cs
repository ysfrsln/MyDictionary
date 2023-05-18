using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T1,T2>
    {
        T1[] _array1;
        T2[] _array2;
        T1[] _tempArray1;
        T2[] _tempArray2;


        public MyDictionary()
        {
            _array1 = new T1[0];
            _array2 = new T2[0];
        }

        public void Add(T1 item1, T2 item2)
        {

            _tempArray1 = _array1;
            _tempArray2 = _array2;

            _array1 = new T1[_array1.Length + 1];
            _array2 = new T2[_array2.Length + 1];


            for (int i = 0; i < _tempArray1.Length; i++)
            {
                _array1[i] = _tempArray1[i];
            }

            for (int i = 0; i < _tempArray2.Length; i++)
            {
                _array2[i] = _tempArray2[i];
            }


            _array1[_array1.Length - 1] = item1;
            _array2[_array2.Length - 1] = item2;

        }


        public void T1s()
        {
            foreach (var item in _array1)
            {
                Console.WriteLine(item);
            }
        }

        public void T2s()
        {
            foreach (var item2 in _array2)
            {
                Console.WriteLine(item2);
            }
        }


        public int Count
        {
            get { return _array1.Length; }

        }


    }
}
