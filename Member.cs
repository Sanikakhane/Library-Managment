namespace Library_Manage
{
    public class Member
    {
        public int Id;
        public string member_name;
        public string member_phone; 
        List<Book> bookhistory =new List<Book> ();
        public Member(int  id, string member_name, string member_phone)
        {
            Id = id;
            this.member_name = member_name;
            this.member_phone = member_phone;
        }
        public void borrowBook(Book book)
        {
            bookhistory.Add(book);
            Console.WriteLine($"The book borrowed by the {member_name} succesfully");
        }
        public void returnBook(int id)
        {
            bookhistory.RemoveAt(id);
        }
        public void showHistory()
        {
            foreach(var book in bookhistory)
            {
                Console.WriteLine($"{book.Id}  {book.Title} {book.borrowDate} {book.returnDate}");
            }
        }
        public void showDetails()
        {
            Console.WriteLine($"Id : {Id} Name: {member_name} ");
        }
    }
}