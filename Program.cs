using UserStack;

internal class Program
{
    internal static void PrintMenu()
    {
        Console.Clear();

        Console.WriteLine("=========================================");
        Console.WriteLine("            Stack Operations Menu        ");
        Console.WriteLine("=========================================");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("[1] Push - Stores an object on top of the stack");
        Console.WriteLine("[2] Pop  - Remove the top element from the stack");
        Console.WriteLine("[3] Peek - View the top element of the stack");
        Console.WriteLine("[4] Print- Display all elements in the stack");
        Console.WriteLine("[5] Clear- Remove all elements from the stack");
        Console.WriteLine("[0] Exit - Exit the application");
        Console.WriteLine("=========================================");
        Console.Write("Enter your choice [1-5] or [0] to exit: ");
    }

    private static void Main(string[] args)
    {
        bool exit = false;
        UserStack_Linked stack = new UserStack_Linked(); // Use the new UserStack_Linked implementation

        while (!exit)
        {
            PrintMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter value to push: ");
                    var value = Console.ReadLine();

                    if (int.TryParse(value, out int intValue))
                    {
                        stack.Push(intValue);
                    }
                    else if (double.TryParse(value, out double doubleResult))
                    {
                        stack.Push(doubleResult);
                    }
                    else if (char.TryParse(value, out char charResult))
                    {
                        stack.Push(charResult);
                    }
                    else if (bool.TryParse(value, out bool boolResult))
                    {
                        stack.Push(boolResult);
                    }
                    else
                    {
                        stack.Push(value); // Assume it's a string if none of the other types match
                    }

                    break;

                case "2":
                    var poppedValue = stack.Pop();
                    if (poppedValue != null)
                    {
                        Console.WriteLine("Popped value: " + poppedValue);
                    }
                    break;

                case "3":
                    var topValue = stack.Peak();
                    if (topValue != null)
                    {
                        Console.WriteLine("Top value: " + topValue);
                    }
                    break;

                case "4":
                    stack.Print();
                    break;

                case "5":
                    bool cleared = stack.Clear();
                    if (cleared)
                    {
                        Console.WriteLine("Stack cleared.");
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