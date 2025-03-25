using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class Node
        {
            public char Data;
            public Node? Next;
            public Node(char data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node? top;

        public BracketValidator()
        {
            top = null;
        }

        public void Push(char item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;
        }

        public char Pop()
        {
            if (top == null)
                return '\0';
            char item = top.Data;
            top = top.Next;
            return item;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            BracketValidator stack = new BracketValidator();
            foreach (char c in ekspresi)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.IsEmpty();
        }
    }
}
