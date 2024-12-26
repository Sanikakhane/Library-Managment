﻿using System;
using System.Collections.Generic;

namespace Library_Manage
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            
            Library_Manager libraryManager = new Library_Manager();
            LibraryItem b1 = new Book("The great nation", "Sanika", 104, 296);
            //libraryManager.AddItem(new Book("The Great Gatsby", "Fitzgerald", 101, 200));
            //libraryManager.AddItem(new Book("Rich dad poor dada", "Kiyosaki", 102, 250));
            //libraryManager.AddItem(new Book("The epitom of courage", "hawkins", 103, 196));
            //libraryManager.AddItem(b1);
            //libraryManager.RemoveItem(102);
            //libraryManager.showAllItems();

            Book b2 = new Book("dfghnm", "dfghjkl", 105);
            Book b3 = new Book("dfghjk", "dfghjkl", 102);


            Member m1= new Member(1,"Sanika","985962631");
            Member m2 = new Member(2, "asdfghjkl", "8543135132");
            Member m3 = new Member(3, "asdfghjkl", "8543135132");
            Member m4 = new Member(4, "asdfghjkl", "8543135132");

            libraryManager.addMember(m1);
            libraryManager.addMember(m2);
            libraryManager.addMember(m3);
            libraryManager.addMember(m4);

            libraryManager.removeMember(2);
            libraryManager.showList();

            libraryManager.checkMember(2);
            m1.borrowBook(b2);
            m1.borrowBook(b3);

            m1.showHistory();

        }
    }
}