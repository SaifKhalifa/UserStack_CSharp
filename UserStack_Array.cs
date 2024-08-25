using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStack
{
    internal class UserStack_Array
    {
        //Variable Declarations.
        static int maxSize;
        int top;
        int[] stack;

        //constructors.
        public UserStack_Array(int size = 10)
        {
            maxSize = size;
            stack = new int[maxSize];
            top = -1;
        }

        //methods
        public bool IsEmpty()
        {
            return top < 0;
        }
    }
}
