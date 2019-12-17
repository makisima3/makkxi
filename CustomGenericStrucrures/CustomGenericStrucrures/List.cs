using System;

namespace CustomGenericStructures
{
    public class List<T> : IList<T>
    {
        public int Count => count;
        public T this[int index]
        {
            get => arrayList[index];
            set => arrayList[index] = value;
        }

        private int count;
        private T[] arrayList = Array.Empty<T>();

        public void Add(T data)
        {
            T[] temporaryArray = new T[arrayList.Length + 1];
            for (int i = 0; i < arrayList.Length; i++)
            {
                temporaryArray[i] = arrayList[i];
            }
            temporaryArray[arrayList.Length] = data;
            arrayList = temporaryArray;
            count = arrayList.Length;
        }

        public bool Remove(T data)
        {
            int index = -1;
            T[] temporaryArray = new T[arrayList.Length - 1];

            for (int i = 0; i < arrayList.Length; i++)
            {
                if (arrayList[i].Equals(data))
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
                        temporaryArray[i] = arrayList[i + 1];
                    }
                    else
                    {
                        temporaryArray[i] = arrayList[i];
                    }
                }
                arrayList = temporaryArray;
                count = arrayList.Length;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            arrayList = Array.Empty<T>();
            count = 0;
        }

        public bool Contains(T data)
        {
            for (int i = 0; i < arrayList.Length; i++)
            {
                if (arrayList[i].Equals(data))
                {
                    return true;
                }
            }
            return false;
        }

        public void AppendFirst(T data)
        {
            T[] temporaryArray = new T[arrayList.Length + 1];
            temporaryArray[0] = data;

            for (int i = 0; i < arrayList.Length; i++)
            {
                temporaryArray[i + 1] = arrayList[i];
            }
            arrayList = temporaryArray;
            count = arrayList.Length;
        }
    }
}
