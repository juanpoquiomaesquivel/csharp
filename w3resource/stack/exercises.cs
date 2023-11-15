/*
1. Write a C# program to implement a stack with Push and pop operations.
Find the top element of the stack and check if the stack is empty or not.
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            JxStack stack = new JxStack();
            System.Console.WriteLine("is Empty? {0}", stack.IsEmpty());
            System
                .Console
                .WriteLine("which is on top? {0}", stack.Top() == null ? "null" : "not null");
            stack.Push(15);
            stack.Push(-7);
            stack.Push(11);
            stack.Show();
            stack.Push(0);
            stack.Push(45);
            stack.Show();
            System.Console.WriteLine("which is on top? {0}", stack.Top());
            stack.Pop();
            stack.Pop();
            stack.Show();
        }
    }

    class JxStack
    {
        private JxNode? _root;

        public JxStack()
        {
            this._root = null;
        }

        public void Push(int Value)
        {
            JxNode node = new JxNode();
            node.Value = Value;
            node.Next = null;

            if (!this.IsEmpty())
                node.Next = this._root;

            this._root = node;
        }

        public void Pop()
        {
            if (!this.IsEmpty())
                this._root = this._root!.Next;
        }

        public int? Top()
        {
            return this._root?.Value;
        }

        public void Show()
        {
            if (!this.IsEmpty())
            {
                System.Console.WriteLine("Stack");
                JxNode? aux = this._root;

                do
                {
                    System.Console.WriteLine(aux!.Value);
                    aux = aux.Next;
                } while (aux != null);
            }
        }

        public bool IsEmpty()
        {
            return this._root is null;
        }

        private class JxNode
        {
            public int Value;
            public JxNode? Next;
        }
    }
}
