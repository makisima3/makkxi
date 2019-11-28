using System.Collections;
using IList;
namespace CustomGenericStructures
{
    public class DoublyLinkedList<T> : IList<T>
    {
        public int Count { get { return count; } }

        public bool IsEmpty { get { return count == 0; } }

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

        DoublyNode<T> current;

        DoublyNode<T> next;

        public T this[int i]
        {
            get
            {
                current = next;
                next = next.Next;
                return current.Data;
            }
            set => current.Data = value;
        }

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
            next = head;
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
            next = head;
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
                next = head;
                return true;
            }
            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
            next = null;
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
