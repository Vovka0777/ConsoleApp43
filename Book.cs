using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43_3
{
    struct Book
    {
        private List<Book> books;
        string name, fio;
        int year;
        int pages;

        public string Name { get => name; set => name = value; }
        public string Fio { get => fio; set => fio = value; }
        public int Year { get => year; set => year = value; }
        public int Pages { get => pages; set => pages = value; }
        internal List<Book> Books { get => books; set => books = value; }

        //internal List<Book> Books { get => books; set => books = value; }

        public Book(string name, string fio, int year, int pages, List<Book> books = null)
        {
            this.name = name;
            this.fio = fio;
            this.year = year;
            this.pages = pages;
            this.books = books ?? new List<Book>();
        }

        public void ShowBook()
        {
            foreach (var book in books)
            {
                for (int i = 1; i < books.Count; i++)
                {
                    Console.WriteLine($"Книга {i}:\nНазвание: {book.name}, Автор: {book.Fio}, Год: {book.Year}, Страниц: {book.Pages}\n\n");
                }      
            }
        }
    }
}
