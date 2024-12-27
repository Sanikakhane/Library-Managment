
namespace Library_Manage
{
    public abstract class LibraryItem
    {
        private string title;
        private string author;
        private int id;

        protected LibraryItem(string title, string author, int id)
        {
            this.title = title;
            this.author = author;
            this.id = id;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public int Id
        {
            get => id;
            private set => id = value;
        }

        public abstract void showDetails();
    }
}
