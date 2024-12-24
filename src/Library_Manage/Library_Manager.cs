namespace Library_Manage
{
    public interface Iborrow
    {
        void BorrowBook(int memberId);
        void ReturnBook(int memebrId);
    }
    public interface Imanage
    {
        void AddItem(LibraryItem item);
        void RemoveItem(int id);
    }
    public class Library_Manager : Imanage
    {
        List<LibraryItem> Items = new List<LibraryItem> ();
        public void AddItem(LibraryItem item)
        {
            Items.Add (item);
            Console.WriteLine($"The {item.Title} added succesfully");
        }
        public void RemoveItem(int id)
        {
            Items.RemoveAll(item=>item.Id==id);
            Console.WriteLine("Book removed succesfully");
        }
        public void showAllItems()
        {
            foreach (var item in Items)
            {
                item.showDetails();      
            }
        }
    }
}