using IList;
using System.Collections;


namespace CustomGenericStructures
{
    public class LinkedList<T> : IList<T>
    {
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

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

        private Node<T> current = null;

        private Node<T> next;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
            next = head;
        }

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
                    next = head;
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
            tail = null;
            next = null;
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
            next = head;
        }

        
    }
}
