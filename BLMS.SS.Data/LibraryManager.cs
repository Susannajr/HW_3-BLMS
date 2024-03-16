using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public static class LibraryManager
    {
        private static List<Book> books = new List<Book>();

        public static void AddBook(Book book)
        {
            books.Add(book);
        }

        public static void RemoveBook(string title)
        {
            Book bookToRemove = books.Find(book => book.Title == title);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }

        public static void ListAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author.Name}, Category: {book.Category.CategoryName}, Year: {book.Year}, Price: {book.Price}");
            }
        }
    }
}
