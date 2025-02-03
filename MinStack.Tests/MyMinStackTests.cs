namespace MinStack.Tests
{
    public class MyMinStackTests
    {
        private readonly MyMinStack _stack;

        public MyMinStackTests()
        {
            _stack = new MyMinStack();
        }

        [Fact]
        public void Push_ShouldAddElementToStack()
        {
            _stack.Push(5);
            Assert.Equal(5, _stack.GetMin());
        }

        [Fact]
        public void Push_MultipleElements_ShouldMaintainMinValue()
        {
            _stack.Push(5);
            _stack.Push(2);
            _stack.Push(8);
            _stack.Push(1);

            Assert.Equal(1, _stack.GetMin());
        }

        [Fact]
        public void Pop_ShouldRemoveElementAndUpdateMin()
        {
            _stack.Push(5);
            _stack.Push(2);
            _stack.Push(8);
            _stack.Push(1);

            _stack.Pop();
            Assert.Equal(2, _stack.GetMin());
        }

        [Fact]
        public void Pop_ShouldRemoveElementsAndUpdateMinTwoTimes()
        {
            _stack.Push(100);
            _stack.Push(200);
            _stack.Push(50);
            _stack.Push(300);
            _stack.Push(400);

            _stack.Pop();
            _stack.Pop();
            _stack.Pop();
            Assert.Equal(100, _stack.GetMin());
        }

        [Fact]
        public void Pop_EmptyStack_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Pop());
        }

        [Fact]
        public void GetMin_EmptyStack_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.GetMin());
        }
    }
}