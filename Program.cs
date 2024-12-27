using System;
using System.Collections.Generic;

namespace Library_Manage
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            Library_Manager libraryManager = new Library_Manager();

            int memberId = 101;
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. Remove Member");
            Console.WriteLine("3. Show Members");
            Console.WriteLine("4. Add Item");
            Console.WriteLine("5. Remove Item");
            Console.WriteLine("6. Show Items");
            Console.WriteLine("7. Borrow Book");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    memberId++;
                    Console.WriteLine("Enter The name");
                    string memberName = ValidString();
                    Console.WriteLine("Enter Phone number");
                    string memberPhone = ValidString();
                    var newMember = new Member(memberId, memberName, memberPhone);
                    libraryManager.addMember(newMember);
                    Console.WriteLine($"The Id of the member is {memberId}");
                    break;

                case "2":
                    Console.WriteLine("Enter the Id of the member");
                    int id=ValidInt();
                    libraryManager.removeMember(id);
                    break;

                case "3":
                    Console.WriteLine("The List of the members is ");
                    libraryManager.showList();
                    break;

                case "4":
                    Console.Write("Enter book Title: ");
                    string title = ValidString();
                    Console.Write("Enter book Author: ");
                    string author =ValidString();
                    Console.Write("Enter book ID: ");
                    int itemId = ValidInt();
                    Console.WriteLine("Enter page count of the book");
                    int pageCount=ValidInt();
                    libraryManager.AddItem(new Book(title, author, itemId, pageCount));
                    break;

                case "5":
                    Console.Write("Enter Item ID to Remove: ");
                    itemId = ValidInt();
                    libraryManager.RemoveItem(itemId);
                    break;

                case "6":
                    libraryManager.showAllItems();
                    break;

                case "7":
                    Console.Write("Enter Member ID: ");
                    memberId = ValidInt();
                    Console.Write("Enter Book ID: ");
                    itemId = ValidInt();
                    Member member = libraryManager.Members.FirstOrDefault(m => m.Id == memberId);
                    LibraryItem book = libraryManager.Items.FirstOrDefault(b => b.Id == itemId);
                    if (member != null && book != null)
                    {
                        member.borrowBook((Book)book);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Member or Book ID.");
                    }
                    break;

                case "8":
                    Console.WriteLine("Exiting the application.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }
        private static int ValidInt()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        throw new ArgumentNullException("Input cannot be null or empty.");
                    return int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format. Please enter a valid integer.");
                }
            }
        }
        private static string ValidString()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        throw new ArgumentNullException("Input cannot be null or empty.");
                    return input;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}