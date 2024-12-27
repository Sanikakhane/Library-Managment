
namespace Library_Manage
{
    public abstract class LibraryItem
    {
        public string Title;
        public string Author;
        public int Id;
        public LibraryItem(string title, string author,int Id)
        {
            Title = title;
            Author = author;
            this.Id = Id;
        }
        public abstract void showDetails();
    }
    public class Book : LibraryItem
    {
        public int pageCount;
        public DateTime borrowDate;
        public DateTime returnDate;
        public bool avilable = true;
        public Book(string title,string author,int Id) : base(title, author, Id) { }
        public Book(string title,string author,int Id,int pageCount):base(title,author,Id)
        {
            this.pageCount = pageCount;
        }
        public override void showDetails()
        {
            Console.WriteLine($"Book : {Title}  Author : {Author} Id : {Id}");
        }
    }
    

    
}