using System;
namespace UserStack
{
    internal class UserStack_Array<T>
    {
        //Variable Declarations.
        int maxSize;
        int top;
        T[] stack;
        //error msgs
        readonly string emptyMsg = "\aStack is empty!, push some values first.";
        readonly string fullMsg = "\aStack is FULL!, pop some values first.";

        //constructors.
        public UserStack_Array(int size = 5)
        {
            maxSize = size;
            stack = new T[maxSize];
            top = -1;
        }

        //methods
        internal bool IsEmpty()
        {
            return top < 0;
        }
        internal bool IsFull()
        {
            return top >= maxSize - 1;
        }

        internal bool Push(T value)
        {
            if (!IsFull())
            {
                top++;
                stack[top] = value;
                Console.WriteLine(value + " pushed on top of the stack!");
                return true;
            }
            else
            {
                Console.WriteLine(fullMsg);
                return false;
            }
        }

        internal T Pop() 
        {
            if(IsEmpty())
            {
                Console.WriteLine(emptyMsg);
                return default;
            }
            else
            {               
                T value = stack[top];
                top--;
                //Console.WriteLine("Popped value = " + value);
                return value;
            }
        }

        internal void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine(emptyMsg);
                return;
            }

            Console.WriteLine("\nItems in stack:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }

        internal T Peak() 
        {
            if (IsEmpty())
            {
                Console.WriteLine(emptyMsg);
                return default;
            }
            else
                return stack[top];
        }

        internal bool Clear()
        {
            if (!IsEmpty())
            {
                for(int i = 0; i <= top; i++)
                {
                    stack[i] = default;
                }
                //Array.Clear(stack);
                
                top = -1;             
                return true;
            }
            else
            {
                Console.WriteLine("\aStack is empty!, push some values first.");
                return false;
            }
        }
    }
}
