namespace C_.Leetcode
{
    public class MinStack
    {
        LinkedList<int> stack;
        public MinStack()
        {
            stack = new LinkedList<int>();
        }

        public void Push(int val)
        {

           stack.AddFirst(val);
        }
        

        public void Pop()
        {
            stack.RemoveFirst();
        }

        public int Top()
        {
            return stack.First();
        }

        public int GetMin()
        {
            return stack.Min();
        }
    }
}
