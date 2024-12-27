namespace Library_Manage
{
    public class Book : LibraryItem
    {
        private int pageCount;
        private DateTime borrowDate;
        private DateTime returnDate;
        private bool available;

        public Book(string title, string author, int id) : base(title, author, id)
        {
            available = true;
        }

        public Book(string title, string author, int id, int pageCount) : base(title, author, id)
        {
            pageCount = pageCount;
            available = true;
        }

        public int PageCount
        {
            get => pageCount;
            set => pageCount = value;
        }

        public DateTime BorrowDate
        {
            get => borrowDate;
            set => borrowDate = value;
        }

        public DateTime ReturnDate
        {
            get => returnDate;
            set => returnDate = value;
        }

        public bool Available
        {
            get => available;
            set => available = value;
        }

        public override void showDetails()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}, ID: {Id}, Available: {Available}");
        }
    }
}
