using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStack
{
    internal class UserStack_Array<T>
    {
        //Variable Declarations.
        static int maxSize;
        int top;
        T[] stack;

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
            return top >= maxSize;
        }

        internal void Push(T value)
        {
            if (IsFull())
            {
                Console.WriteLine("\aStack is FULL!, pop some values first.");
            }
            else
            {
                top++;
                stack[top] = value;
            }
        }

        internal T Pop() 
        {
            if(IsEmpty())
            {
                Console.WriteLine("\aStack is EMPTY!, push some values first.");
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
                Console.WriteLine("\aStack is EMPTY!, push some values first.");
                return;
            }

            Console.WriteLine("\nItems in stack:");
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }

        internal T Peak() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("\aStack is EMPTY!, push some values first.");
                return default;
            }
            else
                return stack[top];
        }

        internal bool Clear()
        {
            if (!IsEmpty())
            {
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
