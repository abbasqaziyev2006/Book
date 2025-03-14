namespace ConsoleApp3
{
    class Library
    {
        private List<Book> _books = new List<Book>();

        public void AddBook()
        {
            Console.WriteLine("Process of adding a book:");
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Book newBook = new Book(title, author);
            _books.Add(newBook);
            Console.WriteLine($"Added: {newBook.Title} by {newBook.Author} (ID: {newBook.BookId})");
        }

        public void RemoveBook()
        {
            PrintBooks();
            Console.WriteLine("Process of removing:");
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());

            int findIndex = -1;


            for (int i = 0; i < _books.Count; i++)
            {
                if (_books[i].BookId == id)
                {
                    findIndex = i;
                    break;
                }
            }
            if (findIndex != -1)
            {
                _books.RemoveAt(findIndex);
                Console.WriteLine("Removed successfully");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void PrintBooks()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"{"ID",-5}  {"Name",-20}   {"Author",-20}");
            foreach (Book book in _books)
            {
                if (book == null) continue;
                Console.WriteLine($"{book.BookId,-5} {book.Title,-20} {book.Author,-20}");
                Console.WriteLine(new string('-', 50));
            }
        }
        public void ReturnBook()
        {
            Console.Write("Enter the Book ID to return: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < _books.Count; i++)
            {
                if (_books[i].BookId == id)
                {
                    if (_books[i].IsAvailable)
                    {
                        Console.WriteLine("This book is already in the library!");
                        return;
                    }

                    _books[i].IsAvailable = true;
                    Console.WriteLine($"You successfully returned '{_books[i].Title}'!");
                    return;
                }
            }
            Console.WriteLine("Book not found!");
        }

        public void BorrowBook()
        {
            Console.Write("Enter the Book ID: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < _books.Count; i++)
            {
                if (_books[i].BookId == id)
                {
                    if (!_books[i].IsAvailable)
                    {
                        Console.WriteLine("This book is already borrowed!");
                        return;
                    }

                    _books[i].IsAvailable = false;
                    Console.WriteLine($"You successfully borrowed '{_books[i].Title}'!");
                    return;
                }
            }

            Console.WriteLine("Book not found!");
        }



        public Book FindBookById()
        {
            Console.Write("Enter ID:");
            int id = int.Parse(Console.ReadLine());
            Book FoundBook = null;
            foreach (var book in _books)
            {
                if (book.BookId == id)
                    FoundBook = book;
                break;
            }

            if (FoundBook != null)
            {
                Console.WriteLine("Book Found:");
                Console.WriteLine($"ID: {FoundBook.BookId}");
                Console.WriteLine($"Title: {FoundBook.Title}");
                Console.WriteLine($"Author: {FoundBook.Author}");
                Console.WriteLine($"Status: {FoundBook.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            return FoundBook;
        }

       
    }
}
