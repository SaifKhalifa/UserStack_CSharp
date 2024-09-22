namespace UserStack_Queue
{    
    internal class UserQueue_Linked
    {
        //Variable Declarations.
        Node front;
        Node rear;

        //error msgs
        readonly string emptyMsg = "\aQueue is empty!, enqueue some values first.";

        //constructors.
        public UserQueue_Linked()
        {
            front = rear = null;
        }

        // Methods
        public void Enqueue(object dataValue)
        {
            Node newNode = new Node(dataValue);

            if (rear == null)//empty
            {
                front = rear = newNode;
                Console.WriteLine(dataValue + " is enqueued to the queue!\n");
                return;
            }

            rear.nextNode = newNode;
            rear = newNode;

            Console.WriteLine(dataValue + " is enqueued to the queue!\n");
        }

        public object Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine(emptyMsg);
                return null;
            }

            object dequeuedValue = front.data;
            
            front = front.nextNode; // move the frnt pointer to the next node

            if (front == null)
            {
                rear = null;
            }

            return dequeuedValue;
        }

        internal object Peak()
        {
            if (front == null)
            {
                Console.WriteLine(emptyMsg);
                return null;
            }
            return front.data;
        }

        internal void Print()
        {
            if (front == null)
            {
                Console.WriteLine(emptyMsg);
                return;
            }

            Console.WriteLine("\nItems in queue:");
            Node current = front;
            while (current != null)
            {
                Console.WriteLine("Value: " + current.data + "\tType: " + current.dataType);
                current = current.nextNode;
            }
        }

        internal bool Clear()
        {
            if (front != null)
            {
                front = rear = null;  // unlink all nodes.
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