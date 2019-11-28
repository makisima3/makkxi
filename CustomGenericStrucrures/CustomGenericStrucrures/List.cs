using IList;
using System.Collections;


namespace CustomGenericStructures
{
    public class List<T> : IList<T>
    {
        public int Count { get { return count; } }

        private T[] array = new T[0];

        private int count;

        public T this[int i]
        {
            get => array[i];
            set => array[i] = value;
        }

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
    }
}
