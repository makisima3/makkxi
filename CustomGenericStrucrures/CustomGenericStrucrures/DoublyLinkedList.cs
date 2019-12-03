using System.Collections;
using IList;
namespace CustomGenericStructures
{
    public class DoublyLinkedList<T> : IList<T>
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

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public T this[int i]
        {
            get
            {
                current = head;
                for (int g = 0; g < i; g++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                current = head;
                for (int g = 0; g < i; g++)
                {
                    current.Data = value;
                }
            }
        }

        private DoublyNode<T> head;
        private DoublyNode<T> current;
        private int count;

        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> current;
            if (head == null)
                head = node;
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

        public void AppendFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
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

        public void Clear()
        {
            head = null;
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
    }
}
