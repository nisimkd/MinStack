namespace MinStack
{
    public class MyMinStack
    {
        private Stack<int> _stack = new Stack<int>();
        private Stack<int> _minimumStack = new Stack<int>();

        public void Push(int x)
        {
            _stack.Push(x);

            // Add x to the minimum stack only if it will be the new minimum value
            if (_minimumStack.Count == 0 || x <= _minimumStack.Peek())
            {
                _minimumStack.Push(x);
            }
        }

        public int Pop()
        {
            if (_stack.TryPop(out int res))
            {
                int min = _minimumStack.Peek();

                if (min == res)
                {
                    _minimumStack.Pop();
                }

                return res;
            }

            throw new InvalidOperationException("Stack is empty.");
        }

        public int GetMin()
        {
            if (_minimumStack.TryPeek(out int min))
            {
                return min;
            }

            throw new InvalidOperationException("Stack is empty.");
        }
    }
}
