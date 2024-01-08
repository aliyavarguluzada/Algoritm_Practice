using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_Practice
{
    public class LinkedList<T>
    {
        private Node<T> head;
        public LinkedList()
        {
            head = null;
        }

        public void AddFront(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
        }

        public void AddBack(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;

        }
    }

}
