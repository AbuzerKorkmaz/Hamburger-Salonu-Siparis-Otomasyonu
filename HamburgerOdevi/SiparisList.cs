using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdevi
{
    public class SiparisList<T> : ICollection<T>
    {
        private T[] siparis;
        public SiparisList()
        {
                siparis = new T[0];
        }
        public int Count => siparis.Length;

        public bool IsReadOnly => siparis.IsReadOnly;

        public void Add(T item)
        {
            Array.Resize(ref siparis, siparis.Length+1);
            siparis[siparis.Length - 1] = item;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class SiparisListEnumerator <T>: IEnumerator<T>
    {
        T[] temp;
        int index= -1;
        public SiparisListEnumerator(T[] dizi)
        {
            temp = dizi;   
        }
        public T Current => temp[index];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            index++;
            return index<temp.Length;
        }

        public void Reset()
        {
            index=-1;
        }
    }
}
