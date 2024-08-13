﻿using System.Collections.Generic;

namespace XppInterpreter.Parser
{
    public class ParseContextStack : ParseContextStack<bool>
    {
        public void New()
        {
            New(true);
        }
    }

    public class ParseContextStack<T>
    {
        protected readonly Stack<T> _stack = new Stack<T>();
        public bool Empty => _stack.Count == 0;

        public void New(T value)
        {
            _stack.Push(value);
        }

        public T Release()
        {
            return _stack.Pop();
        }

        public T Peek()
        {
            return _stack.Peek();
        }
    }
}
