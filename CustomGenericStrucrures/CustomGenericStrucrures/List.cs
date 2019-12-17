using System;

namespace CustomGenericStructures
{
    public class List<T> : IList<T>
    {
        public int Count => count;
        public T this[int index]
        {
            get => listItems[index];
            set => listItems[index] = value;
        }

        private int count;
        private T[] listItems = Array.Empty<T>();

        public void Add(T data)
        {
            T[] temporaryArray = new T[listItems.Length + 1];

            for (int i = 0; i < listItems.Length; i++)
            {
                temporaryArray[i] = listItems[i];
            }

            temporaryArray[listItems.Length] = data;
            listItems = temporaryArray;
            count = listItems.Length;
        }

        public bool Remove(T data)
        {
            int index = -1;
            T[] temporaryArray = new T[listItems.Length - 1];

            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].Equals(data))
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                for (int i = 0; i < temporaryArray.Length; i++)
                {
                    if (i >= index)
                    {
                        temporaryArray[i] = listItems[i + 1];
                    }
                    else
                    {
                        temporaryArray[i] = listItems[i];
                    }
                }
                listItems = temporaryArray;
                count = listItems.Length;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            listItems = Array.Empty<T>();
            count = 0;
        }

        public bool Contains(T data)
        {
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].Equals(data))
                {
                    return true;
                }
            }
            return false;
        }

        public void AppendFirst(T data)
        {
            T[] temporaryArray = new T[listItems.Length + 1];
            temporaryArray[0] = data;

            for (int i = 0; i < listItems.Length; i++)
            {
                temporaryArray[i + 1] = listItems[i];
            }

            listItems = temporaryArray;
            count = listItems.Length;
        }
    }
}
