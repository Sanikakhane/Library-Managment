namespace Library_Manage
{
    public interface ImanageItem
    {
        void AddItem(LibraryItem item);
        void RemoveItem(int id);
    }
    public interface ImanageMember
    {
        void addMember(Member m);
        void removeMember(int id);
        void checkMember(int id);
        void showList();
    }
    public class Library_Manager : ImanageItem,ImanageMember
    {
        public List<LibraryItem> Items = new List<LibraryItem> ();
        public List<Member> Members = new List<Member> ();
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
        public void addMember(Member m)
        {

            Members.Add (m);
            Console.WriteLine($"Member with  {m.Id} Id added succesfully");
        }
        public void removeMember(int id)
        {
            Members.RemoveAll(item=>item.Id==id);
            Console.WriteLine("The member removed succesfully");
        }
        public void checkMember(int id)
        {
            if(Members.Any(item=>item.Id==id))
            {
                Console.WriteLine("Member is present");
            }
            else
            {
                Console.WriteLine("Member is not Present");
            }
        }
        public void showList()
        {
            foreach(var item in Members)
            {
                item.showDetails();
            }
        }
    }
}