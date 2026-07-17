Stack<string> history = new Stack<string>();
string currentPage = "No page loaded";
Console.WriteLine("Browser History Menu");
Console.WriteLine("1. Visit a new webpage");
Console.WriteLine("2. Go Back");
Console.WriteLine("3. View current page");
Console.WriteLine("4. Display browsing history");
Console.WriteLine("5. Exit");

while (true)
{
    Console.Write("Enter choice: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 5)
    {
        Console.WriteLine("Closing browser. Goodbye!");
        return;
    }

    switch (choice)
    {
        case 1:
            Console.Write("Enter webpage URL: ");
            string newPage = Console.ReadLine();
            if (currentPage != "No page loaded")
            {
                history.Push(currentPage);
            }
            currentPage = newPage;
            Console.WriteLine($"Visited: {currentPage}");
            break;

        case 2:
            if (history.Count > 0)
            {
                currentPage = history.Pop();
                Console.WriteLine($"Went back to: {currentPage}");
            }
            else
            {
                Console.WriteLine("No history to go back to!");
            }
            break;

        case 3:
            Console.WriteLine($"Current Page: {currentPage}");
            break;

        case 4:
            Console.WriteLine("\n--- Browsing History (Back Stack) ---");
            if (history.Count == 0)
            {
                Console.WriteLine("History is empty.");
            }
            else
            {
                foreach (string page in history)
                {
                    Console.WriteLine(page);
                }
            }
            break;

        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }
}