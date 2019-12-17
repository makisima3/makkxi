using System;

namespace CustomGenericStructures
{
    public class LinkedList<T> : IList<T>
    {
        private class Node<T>
        {
            public Node(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }

        public int Count => count;
        public bool IsEmpty => count == 0;
        public T this[int index]
        {
            get
            {
                current = head;

                if ((index < 0) || (index >= count))
                {
                    throw new IndexOutOfRangeException();
                }

                for (int g = 0; g < index; g++)
                {
                    current = current.Next;
                }

                return current.Data;
            }
            set
            {
                current = head;

                if ((index < 0) || (index >= count))
                {
                    throw new IndexOutOfRangeException();
                }

                for (int g = 0; g <= index; g++)
                {
                    if (g == index)
                    {
                        current.Data = value;
                    }

                    current = current.Next;
                }
            }
        }

        private Node<T> head;
        private Node<T> current;
        private int count;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> current;

            if (head == null)
            {
                head = node;
            }
            else
            {
                current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
            }

            count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        head = head.Next;
                    }

                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            count++;
        }
    }
}
