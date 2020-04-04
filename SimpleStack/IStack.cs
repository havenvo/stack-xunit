using System;

namespace SimpleStack
{
    public interface IStack
    {
        void Clear();

        bool Contains(string value);

        string Peek();

        void Push(string value);

        string Pop();

        bool IsEmpty();
    }

    public class StackEmptyException : Exception
    {

    }
}
