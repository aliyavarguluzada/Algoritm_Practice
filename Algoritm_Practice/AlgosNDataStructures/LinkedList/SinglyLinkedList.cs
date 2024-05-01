namespace Algoritm_Practice.AlgosNDataStructures.LinkedList
{
    public class SinglyLinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head { get; set; }
        public int Count
        {
            get
            {
                return NodeCount();
            }
        }
        public SinglyLinkedList()
        {
            Head = null;
        }


        public void PrintList()
        {
            Node<T> current = Head;


            while (current != null)
            {
                Console.Write(current.Data + " --> ");
                current = current.Next;
            }
            if (current is null)
            {
                Console.Write(" null");
            }

        }

        public void AddNodeBack(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                return;
            }
            else
            {
                Node<T> current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void AddNodeFront(T data)
        {
            Node<T> newNode = new Node<T>(data);

            newNode.Next = Head;
            Head = newNode;
        }

        public void AddNodePosition(T data, int position)
        {
            Node<T> newNode = new Node<T>(data);

            if (position == 1)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node<T> previous = Head;
                int count = 1;

                while (count < position - 1)
                {
                    previous = previous.Next;
                    count++;
                }
                Node<T> current = previous.Next;
                newNode.Next = current;
                previous.Next = newNode;
            }
        }

        public Node<T> DeleteFirst()
        {
            if (Head == null)
                return null;
            Node<T> temp = Head;
            Head = Head.Next;
            temp.Next = null;
            return temp;
        }
        public Node<T> DeleteLast()
        {
            if (Head == null || Head.Next == null)
                return Head;

            Node<T> current = Head;
            Node<T> previous = null;

            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            previous.Next = null;
            return current;
        }


        public void DeleteNodePosition(T data, int position)
        {
            if (position == 1)
                Head = Head.Next;
            else
            {
                Node<T> previous = Head;

                int count = 1;

                while (count < position - 1)
                {
                    previous = previous.Next;
                    count++;
                }
                Node<T> current = previous.Next;
                previous.Next = current.Next;
            }

        }

        public bool SearchElement(T searchKey)
        {
            Node<T> current = Head;

            while (current != null)
            {
                // if (current.Data == searchKey)
                if (current.Data.Equals(searchKey))
                    return true;

                current = current.Next;
            }

            return false;
        }


        public Node<T> Reverse()
        {
            if (Head == null)
                return Head;

            Node<T> current = Head;

            Node<T> previous = null;

            Node<T> next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;

                previous = current;

                current = next;

            }
            return previous;
        }

        public Node<T> FindNthNode(int n)
        {
            if (Head == null || n <= 0)
                return null;

            Node<T> current = Head;
            int count = 1;

            while (current != null && count < n)
            {
                current = current.Next;
                count++;
            }


            return current;
        }

        public Node<T> getNthNodeFromEnd(int n)
        {
            if (Head == null)
                return null;

            if (n <= 0)
                throw new ArgumentOutOfRangeException();

            Node<T> mainPtr = Head;
            Node<T> refPtr = Head;



            int count = 0;

            while (count < n)
            {
                if (refPtr == null)
                    throw new ArgumentNullException();

                refPtr = refPtr.Next;
                count++;
            }

            while (refPtr != null)
            {
                refPtr = refPtr.Next;

                mainPtr = mainPtr.Next;

            }
            return mainPtr;
        }




        public void removeDuplicateFromSortedList()
        {
            Node<T> current = Head;

            while (current != null && current.Next != null)
            {
                //if(current.Data == current.Next.Data)
                if (current.Data.Equals(current.Next.Data))
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
        }


        public Node<T> InsertNodeSortedList(T data)
        {
            Node<T> newNode = new(data) { Next = null };

            if (Head == null || Head.Data.CompareTo(data) >= 0)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null && current.Next.Data.CompareTo(data) < 0)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }

            return Head;
        }


        public Node<T> DeleteNodeContainingKey(T key)
        {
            Node<T> current = Head;

            while (current != null && !current.Next.Data.Equals(key))
            {
                current = current.Next;

            }

            if (current == null)
                return current;

            current.Next = current.Next.Next;

            return current;

        }

        public bool ContainsLoop()
        {
            Node<T> fastPtr = Head;

            Node<T> slowPtr = Head;

            while (fastPtr != null && fastPtr.Next != null)
            {
                fastPtr = fastPtr.Next.Next;

                slowPtr = slowPtr.Next;

                if (slowPtr == fastPtr)
                    return true;
            }

            return false;
        }


        private int NodeCount()
        {
            Node<T> current = Head;

            if (Head == null)
                return 0;

            int count = 0;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

    }
}
