using GraphApp;
using System;
using System.Collections.Generic;

namespace TreeAnim
{
    public static class PostfixTree
    {
        static int op_prec(char op)
        {
            switch (op)
            {
                case '=':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    break;
            }
            return 0;
        }
        static bool isOp(char op)
        {
            switch (op)
            {
                case '=':
                case '+':
                case '-':
                case '*':
                case '/':
                case '^':
                    return true;
                default:
                    return false;
            }
        }
        public static Node Parse(string exp)
        {
            try
            {
                Queue<Node> nodes = new Queue<Node>();
                Stack<char> ops = new Stack<char>();
                foreach (char c in exp)
                {
                    if (char.IsWhiteSpace(c))
                        continue;
                    if (char.IsLetter(c))
                    {
                        nodes.Enqueue(new Node(c));
                    }
                    else if (c == '(')
                        ops.Push(c);
                    else if (c == ')')
                    {
                        while (ops.Peek() != '(')
                        {
                            nodes.Enqueue(new Node(ops.Pop()));
                        }
                        ops.Pop();
                    }
                    else
                    {
                        while (ops.Count > 0 && op_prec(ops.Peek()) >= op_prec(c))
                        {
                            nodes.Enqueue(new Node(ops.Pop()));
                        }
                        ops.Push(c);
                    }
                }
                if(ops.Contains('('))
                    throw new Exception();
                while (ops.Count > 0)
                    nodes.Enqueue(new Node(ops.Pop()));

                Stack<Node> eval = new Stack<Node>();
                while (nodes.Count > 0)
                {
                    Node node = nodes.Dequeue();
                    if (isOp(node.text[0]))
                    {
                        Node right = eval.Pop();
                        Node left = eval.Pop();
                        node.AddSubNode(left);
                        node.AddSubNode(right);
                    }
                    eval.Push(node);
                }
                if (eval.Count == 1)
                    return eval.Pop();
                else
                    throw new Exception();
            }
            catch
            {
                return null;
            }
        }
    }
}
