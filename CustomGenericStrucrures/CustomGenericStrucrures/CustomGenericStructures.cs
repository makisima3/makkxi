using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericStructures
{
    public interface IList<T> : IEnumerable<T>
    {
        void Add(T data);
        bool Remove(T data);
        //int Count();
        //bool IsEmpty();
        void Clear();
        bool Contains(T data);
        void AppendFirst(T data);
    }

    public class List<T> : IList<T>, IEnumerable<T>
    {
        public T[] array = new T[0];
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
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            IEnumerator ie = array.GetEnumerator();
            while (ie.MoveNext())
            {
                T item = (T)ie.Current;
                yield return item;
            }
        }
    }


    public class LinkedList<T> : IEnumerable<T>, IList<T>
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
        Node<T> head;
        Node<T> tail;
        int count;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

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


                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    public class DoublyLinkedList<T> : IEnumerable<T>, IList<T>
    {
        private class DoublyNode<T>
        {
            public DoublyNode(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public DoublyNode<T> Previous { get; set; }
            public DoublyNode<T> Next { get; set; }
        }

        DoublyNode<T> head;
        DoublyNode<T> tail;
        int count;
        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AppendFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        public bool Remove(T data)
        {
            DoublyNode<T> current = head;


            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {

                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            DoublyNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}

