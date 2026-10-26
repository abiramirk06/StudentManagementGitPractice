
Console.WriteLine("=== Student Management System ===");
Console.WriteLine("1. Add Student");
Console.WriteLine("2. View Students");
Console.WriteLine("3. Exit");

Console.Write("Enter your choice: ");
string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Add Student selected.");
        break;

    case "2":
        Console.WriteLine("View Students selected.");
        break;

    case "3":
        Console.WriteLine("Exiting application.");
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}
