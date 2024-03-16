using System;

namespace LibraryManagementSystem : LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. List All Books");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        ListAllBooks();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter author name: ");
            string authorName = Console.ReadLine();

            Console.Write("Enter author biography: ");
            string authorBio = Console.ReadLine();

            Console.Write("Enter category name: ");
            string categoryName = Console.ReadLine();

            Console.Write("Enter category description: ");
            string categoryDesc = Console.ReadLine();

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Author author = new Author(authorName, authorBio);
            Category category = new Category(categoryName, categoryDesc);
            Book book = new Book(title, author, category, year, price);

            LibraryManager.AddBook(book);
            Console.WriteLine("Book added successfully.");
        }

        static void RemoveBook()
        {
            Console.Write("Enter book title to remove: ");
            string title = Console.ReadLine();

            LibraryManager.RemoveBook(title);
            Console.WriteLine("Book removed successfully.");
        }

        static void ListAllBooks()
        {
            LibraryManager.ListAllBooks();
        }
    }
}