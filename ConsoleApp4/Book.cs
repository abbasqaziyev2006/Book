namespace ConsoleApp3
{
    class Book
    {
        private static int _autoIncrementId = 1;
        public int BookId { get; }
        public string Title { get; }
        public string Author { get; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author)
        {
            BookId = _autoIncrementId++;
            Title = title;
            Author = author;
            IsAvailable = true;
        }
    }
}