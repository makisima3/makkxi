namespace IList
{
        public interface IList<T> 
    {
            void Add(T data);
            bool Remove(T data);
            //int Count();
            int Count { get; }
            T this[int i]
            {
                get;
                set;
            }
            void Clear();
            bool Contains(T data);
            void AppendFirst(T data);
        }
    
}
