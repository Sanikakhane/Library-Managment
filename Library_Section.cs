namespace Library_Manage
{
    public class LibrarySections
    {
        public string[] Sections = { "Fiction", "Non-Fiction", "Reference", "Children" };

        public void DisplaySections()
        {
            Console.WriteLine("Library Sections:");
            foreach (var section in Sections)
            {
                Console.WriteLine(section);
            }
        }
    }
}