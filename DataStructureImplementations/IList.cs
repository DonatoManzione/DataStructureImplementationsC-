using System;
namespace DataStructures
{
    public interface IList<E>
    {
        int Count { get;}
        void Add(E data);
        LinkedListNode<E> Find(E data);
        void Remove(E data);
        void Clear();
    }
}
