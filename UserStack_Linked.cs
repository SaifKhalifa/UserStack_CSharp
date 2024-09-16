namespace UserStack
{
    internal class Node
    {
        public object data;
        public Node nextNode;

        public Node(object dataValue) 
        {
            data = dataValue;
            nextNode = null;
        }
    }
    internal class UserStack_Linked
    {
        //Variable Declarations.
        Node top;

        //error msgs
        readonly string emptyMsg = "\aStack is empty!, push some values first.";

        //constructors.
        public UserStack_Linked()
        {
            //maxSize = size;
            //stack = new object[maxSize];
            top = null;
        }

        //methods
        public Node GetNode(object dataValue)
        {
            Node node = new Node(dataValue);
            return node;
        }
        public void Push(object dataValue)
        {
            Node newNode = new Node(dataValue);

            if (top != null)
            {
                newNode.nextNode = top;
                top = newNode;

                Console.WriteLine(dataValue + " is pushed to the stack!\n");
            }
            else //top == null
            {
                top = newNode;
                return;
            }
        }
        public object Pop()
        {
            if (top == null)
            {
                Console.WriteLine(emptyMsg);
                return null;                 
            }

            object poppedValue = top.data;
            top = top.nextNode;  
            
            return poppedValue;           
        }
        internal void Print()
        {
            if (top == null)
            {
                Console.WriteLine(emptyMsg);
                return;
            }

            Console.WriteLine("\nItems in stack:");
            Node current = top;
            while (current != null)
            {
                Console.WriteLine("Value: " + current.data + "\tType: " + current.data.GetType());
                current = current.nextNode;
            }
        }
        internal object Peak()
        {
            if (top == null)
            {
                Console.WriteLine(emptyMsg);
                return null;
            }
            else
            {
                return top.data;
            }
        }
        internal bool Clear()
        {
            if (top != null)
            {
                top = null;  // Unlink all nodes.
                return true;
            }
            else
            {
                Console.WriteLine(emptyMsg);
                return false;
            }
        }

    }
}