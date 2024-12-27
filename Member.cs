namespace Library_Manage
{
    public class Member
    {
        private readonly List<Book> bookHistory = new List<Book>();

        public Member(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public int Id { get; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public void borrowBook(Book book)
        {
            bookHistory.Add(book);
            book.Available = false;
            Console.WriteLine($"Book '{book.Title}' borrowed by {Name} successfully.");
        }

        public void returnBook(Book book)
        {
            bookHistory.Remove(book);
            book.Available = true;
            Console.WriteLine($"Book '{book.Title}' returned by {Name} successfully.");
        }

        public void showHistory()
        {
            Console.WriteLine($"Borrowing History for {Name}:");
            foreach (var book in bookHistory)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Borrowed: {book.BorrowDate}, Returned: {book.ReturnDate}");
            }
        }

        public void showDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Phone: {Phone}");
        }
    }
}
