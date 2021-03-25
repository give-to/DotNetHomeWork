using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    public class GenericList<T> where T:IComparable
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head { get => head; }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if(tail==null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = head;
            while(node!=null)
            {
                action(node.Data);
                node = node.Next;
            }
            
        }

    }
}
