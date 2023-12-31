/*
6. Write a C# program to find the minimum element in a stack.
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

        public static void SolveExercise3()
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

            JxStack stackAsc = stack.SortAsc();
            stackAsc.Show();
        }

        public static void SolveExercise4()
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

            JxStack stackRev = stack.Reverse();
            stackRev.Show();
        }

        public static void SolveExercise5()
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

            int? maxValue = stack.FindMax();

            Console.WriteLine(
                maxValue == null
                    ? "The stack is empty."
                    : "The maximun element in the stack is: " + maxValue
            );
        }

        public static void SolveExercise6()
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

            int? minValue = stack.FindMin();

            Console.WriteLine(
                minValue == null
                    ? "The stack is empty."
                    : "The minimum element in the stack is: " + minValue
            );
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

        public JxStack SortAsc()
        {
            JxStack stackAsc = new JxStack();

            if (!this.IsEmpty())
            {
                JxNode? aux;
                bool flag;
                int count,
                    max,
                    maxIgnore = Int32.MaxValue;

                do
                {
                    aux = this._root;
                    flag = false;
                    count = 1;
                    max = Int32.MinValue;

                    do
                    {
                        if (aux!.Value >= max && aux!.Value < maxIgnore)
                        {
                            if (aux!.Value == max)
                                count++;

                            max = aux!.Value;
                            flag = true;
                        }

                        aux = aux.Next;
                    } while (aux != null);

                    if (flag)
                    {
                        for (int i = 0; i < count; i++)
                            stackAsc.Push(max);

                        maxIgnore = max;
                    }
                } while (flag);
            }

            return stackAsc;
        }

        public JxStack Reverse()
        {
            JxStack stackRev = new JxStack();

            if (!this.IsEmpty())
            {
                JxNode? aux = this._root;

                do
                {
                    stackRev.Push(aux!.Value);
                    aux = aux.Next;
                } while (aux != null);
            }

            return stackRev;
        }

        public int? FindMax()
        {
            if (!this.IsEmpty())
            {
                JxNode? aux = this._root;
                int max = Int32.MinValue;

                do
                {
                    if (aux!.Value > max)
                        max = aux!.Value;

                    aux = aux.Next;
                } while (aux != null);

                return max;
            }

            return null;
        }

        public int? FindMin()
        {
            if (!this.IsEmpty())
            {
                JxNode? aux = this._root;
                int min = aux!.Value;
                aux = aux.Next;

                while (aux != null)
                {
                    if (aux!.Value < min)
                        min = aux!.Value;

                    aux = aux.Next;
                }

                return min;
            }

            return null;
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
