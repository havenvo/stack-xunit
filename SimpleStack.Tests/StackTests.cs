using Xunit;

namespace SimpleStack.Tests
{
    public class StackTests
    {
        [Fact]
        public void NewStackShouldBeEmpty()
        {
            IStack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void PeekAndPopOnEmptyShouldThrow()
        {
            IStack stack = new Stack();
            Assert.Throws<StackEmptyException>(() => stack.Peek());
            Assert.Throws<StackEmptyException>(() => stack.Pop());
        }

        [Fact]
        public void PeekShouldWork()
        {
            IStack stack = new Stack();
            stack.Push("A");

            // Make sure peek doesn't remove item out of the stack
            var result = stack.Peek();
            Assert.Equal("A", result);
            result = stack.Peek();
            Assert.Equal("A", result);

            // Make sure is empty should return false here
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void PopShouldWork()
        {
            IStack stack = new Stack();
            stack.Push("A");

            var result = stack.Pop();
            Assert.Equal("A", result);

            // Make sure that stack is empty
            Assert.Throws<StackEmptyException>(() => stack.Pop());

            // After throw exception, stack should not be broken so is empty should return true
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void VerifyLIFO()
        {
            IStack stack = new Stack();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            Assert.Equal("C", stack.Pop());
            Assert.Equal("B", stack.Pop());
            Assert.Equal("A", stack.Pop());
        }
    }
}