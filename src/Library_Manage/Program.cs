using System;
using System.Collections.Generic;

namespace Library_Manage
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            Book b1 = new Book("abcd", "abcd", 101, 200);

            //LibraryItem l1 = new LibraryItem("Be strong","xyz",102);
            //LibraryItem item = new Book("The Great Gatsby", "Fitzgerald", 101, 200);

            Library_Manager libraryManager = new Library_Manager();
            libraryManager.AddItem(new Book("The Great Gatsby", "Fitzgerald", 101, 200));


            // b1.AddItem(l1);

        }
    }
}