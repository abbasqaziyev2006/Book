using ConsoleApp3;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                Console.Write("Enter command:");
                string command=Console.ReadLine();
                switch (command)
                {
                    case "Print":
                    library.PrintBooks();
                        break;
                    case "Add":
                    library.AddBook();
                        break;
                    case "Remove":
                        library.RemoveBook();
                        break;
                    case "Find":
                        library.FindBookById();
                        break;
                    case "Return":
                        library.ReturnBook();
                        break;
                    case "Borrow":
                        library.BorrowBook();
                        break;
                    case "Exit":
                        return;
                        default:
                        Console.WriteLine("Command is not true");
                        break;
                }
            }
        }
    }
}