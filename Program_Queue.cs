using UserStack_Queue;

internal class Program_Queue
{
    internal static void PrintMenu()
    {
        Console.Clear();

        Console.WriteLine("=========================================");
        Console.WriteLine("            Queue Operations Menu        ");
        Console.WriteLine("=========================================");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("[1] Enqueue - Add an object to the rear of the queue");
        Console.WriteLine("[2] Dequeue - Remove the front element from the queue");
        Console.WriteLine("[3] Peak    - View the front element of the queue");
        Console.WriteLine("[4] Print   - Display all elements in the queue");
        Console.WriteLine("[5] Clear   - Remove all elements from the queue");
        Console.WriteLine("[0] Exit    - Exit the application");
        Console.WriteLine("=========================================");
        Console.Write("Enter your choice [1-5] or [0] to exit: ");
    }

    private static void Main(string[] args)
    {
        bool exit = false;
        UserQueue_Linked queue = new UserQueue_Linked(); // Use the new UserQueue_Linked implementation

        while (!exit)
        {
            PrintMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter value to enqueue: ");
                    var value = Console.ReadLine();

                    if (int.TryParse(value, out int intValue))
                    {
                        queue.Enqueue(intValue);
                    }
                    else if (double.TryParse(value, out double doubleResult))
                    {
                        queue.Enqueue(doubleResult);
                    }
                    else if (char.TryParse(value, out char charResult))
                    {
                        queue.Enqueue(charResult);
                    }
                    else if (bool.TryParse(value, out bool boolResult))
                    {
                        queue.Enqueue(boolResult);
                    }
                    else
                    {
                        queue.Enqueue(value); // Assume it's a string if none of the other types match
                    }

                    break;

                case "2":
                    var dequeuedValue = queue.Dequeue();
                    if (dequeuedValue != null)
                    {
                        Console.WriteLine("Dequeued value: " + dequeuedValue);
                    }
                    break;

                case "3":
                    var frontValue = queue.Peak();
                    if (frontValue != null)
                    {
                        Console.WriteLine("Front value: " + frontValue);
                    }
                    break;

                case "4":
                    queue.Print();
                    break;

                case "5":
                    bool cleared = queue.Clear();
                    if (cleared)
                    {
                        Console.WriteLine("Queue cleared.");
                    }
                    break;

                case "0":
                    exit = true;
                    Console.WriteLine("Bye Bye.");
                    break;

                default:
                    Console.WriteLine("\aInvalid option! Please enter a number between 1 and 5 or 0 to exit the program.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}