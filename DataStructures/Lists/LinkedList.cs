using System.Collections;

namespace DataStructures.Lists
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> HeaderNode { get; set; }
        public LinkedListNode<T> TailNode { get; set; }
        public LinkedListNode<T>[] LinkedListNodes { get; set; }
        public void Add(LinkedListNode<T> node)
        {
            LinkedListNodes.SetValue(node, 0);
        }
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
            Stack stack = new Stack();
        }
        public T Value { get; set; }
        public LinkedList<T> LinkedList { get; private set; }
        public LinkedListNode<T> Previous { get; private set; }
        public LinkedListNode<T> Next { get; private set; }
    }
}
