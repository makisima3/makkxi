namespace IList
{
    public interface IList<T> 
    {       
        int Count { get; }
        T this[int i]
        {
                get;
                set;
        }
        void Add(T data);
        bool Remove(T data);
        void Clear();
        bool Contains(T data);
        void AppendFirst(T data);
    }
}
