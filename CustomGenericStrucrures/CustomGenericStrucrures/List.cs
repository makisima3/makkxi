using IList;
using System.Collections;


namespace List
{
    public class List<T> : IList<T>, System.Collections.Generic.IEnumerable<T>
    {
        private T[] array = new T[0];

        public T this[int i]
        {
            get => array[i];
            set => array[i] = value;
        }

        private int count;

        public int Count { get { return count; } }

        public void Add(T data)
        {
            T[] array1 = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i];
            }
            array1[array.Length] = data;
            array = array1;
            count = array.Length;
        }

        public bool Remove(T data)
        {
            int index = -1;
            T[] array1 = new T[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(data))
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (i >= index)
                    {
                        array1[i] = array[i + 1];
                    }
                    else
                    {
                        array1[i] = array[i];
                    }
                }
                array = array1;
                count = array.Length;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void Clear()
        {
            array = new T[0];
            count = 0;
        }

        public bool Contains(T data)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(data))
                {
                    return true;
                }
            }
            return false;
        }

        public void AppendFirst(T data)
        {
            T[] array1 = new T[array.Length + 1];
            array1[0] = data;
            for (int i = 0; i < array.Length; i++)
            {
                array1[i + 1] = array[i];
            }
            array = array1;
            count = array.Length;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            IEnumerator ie = array.GetEnumerator();
            while (ie.MoveNext())
            {
                T item = (T)ie.Current;
                yield return item;
            }
        }
    }
}
