using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KlassiObecti
{
    struct Book 
    {
        public string? Name;
        public string? Author;
        public int Year;
        public Book(string? name, string? author,int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }
    }
    internal class Library
    {
        public List<Book> list { get; set; } = new();
        public void Add(Book book)
        {
            list.Add(book);
        }
        public void Print()
        {
            int i = 0;
            Console.WriteLine("Библиотека:");
            foreach (Book book in list)
            {
                Console.WriteLine($"{++i} Название: {book.Name} Автор: {book.Author} год: {book.Year}");
            }
        }
        public void SearchName(string name)
        {
            Book result = list.Find(p=>p.Name == name);
            if (!result.Equals(default(Book)))
            {
                Console.WriteLine($"Книга найдена: Название: {result.Name} Автор: {result.Author} год: {result.Year}");
            }
            else Console.WriteLine("Книга не найдена.");
        }
        public void SearchAuthor(string author)
        {
            Book result = list.Find(p => p.Author == author);
            if (!result.Equals(default(Book)))
            {
                Console.WriteLine($"Книга найдена: Название: {result.Name} Автор: {result.Author} год: {result.Year}");
            }
            else Console.WriteLine("Книга не найдена.");
        }
        public void SearchYear(int year) 
        {
            Book result = list.Find(p => p.Year == year);
            if (!result.Equals(default(Book)))
            {
                Console.WriteLine($"Книга найдена: Название: {result.Name} Автор: {result.Author} год: {result.Year}");
            }
            else Console.WriteLine("Книга не найдена.");
        }
        //public void RemoveBook(string name)
        //{
        //    Book result = list.Find(p => p.Name == name);
        //    if (!result.Equals(default(Book)))
        //    {
        //        Console.WriteLine($"Книга найдена: Название: {result.Name} Автор: {result.Author} год: {result.Year}");
        //        Console.WriteLine("Удалить книгу: Y/N?");
        //        string answ=Console.ReadLine();
        //        switch (answ)
        //        {
        //            case "Y":list.Remove(result);
        //                Console.WriteLine("Книга удалена");
        //                break;
        //                case "N": Console.WriteLine("Книга не удалена"); break;
        //        }
        //    }
        //    else Console.WriteLine("Книга не найдена.");
        //}
        public void RemoveIndex()
        {
            int index;
            Console.Write("Введите номер книги для удалеия: ");
            int.TryParse(Console.ReadLine(), out index);
            list.RemoveAt(index-1);
        }
        public void SortByName()
        {
            list.Sort((p1,p2)=>p1.Name!.CompareTo(p2.Name));
        }
        public void SortByAuthor()
        {
            list.Sort((p1, p2) => p1.Author!.CompareTo(p2.Author));
        }
        public void SortByYear()
        {
            list.Sort((p1, p2) => p1.Year!.CompareTo(p2.Year));
        }

    }
}
