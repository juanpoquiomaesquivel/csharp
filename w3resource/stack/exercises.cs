/*
2. Write a C# program to sort the elements of a given stack in descending order.
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

        public static void SolveExercise2()
        {
            JxStack stack = new JxStack();
            stack.Push(15);
            stack.Push(-7);
            stack.Push(-7);
            stack.Push(11);
            stack.Push(-15);
            stack.Push(2);
            stack.Push(0);
            stack.Push(45);
            stack.Push(-7);
            stack.Show();

            JxStack stackDesc = stack.SortDesc();
            stackDesc.Show();
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

        public JxStack SortDesc()
        {
            JxStack stackDesc = new JxStack();

            if (!this.IsEmpty())
            {
                JxNode? aux;
                bool flag;
                int count,
                    min,
                    minIgnore = Int32.MinValue;

                do
                {
                    aux = this._root;
                    flag = false;
                    count = 1;
                    min = Int32.MaxValue;

                    do
                    {
                        if (aux!.Value <= min && aux!.Value > minIgnore)
                        {
                            if (aux!.Value == min)
                                count++;

                            min = aux!.Value;
                            flag = true;
                        }

                        aux = aux.Next;
                    } while (aux != null);

                    if (flag)
                    {
                        for (int i = 0; i < count; i++)
                            stackDesc.Push(min);

                        minIgnore = min;
                    }
                } while (flag);
            }

            return stackDesc;
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

            public JxNode() { }

            public JxNode(int value)
            {
                this.Value = value;
                this.Next = null;
            }
        }
    }
}
