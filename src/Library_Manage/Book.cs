
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
            Id = Id;
        }
        public abstract void showDetails();
    }
    public class Book : LibraryItem
    {
        public int pageCount;
        public Book(string title,string author,int Id,int pageCount):base(title,author,Id)
        {
            pageCount = pageCount;
        }
        public override void showDetails()
        {
            Console.WriteLine($"Book : {Title}  Author : {Author} Id : {Id}");
        }
    }
    

    
}