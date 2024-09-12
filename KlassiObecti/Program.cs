// Объекты и классы
//Задание 1
using KlassiObecti;

//DynamicArray dynamicArray = new DynamicArray();
//dynamicArray.Count = 10;
//dynamicArray.Print();
//dynamicArray.RandomFill();
//dynamicArray.Print();

//dynamicArray.Shuffle();

//dynamicArray.Print();
//Console.WriteLine(dynamicArray.DifCount());

//Задание 2. Библиотека.

Book book1= new Book("Сказка","Иван Иванов",1995);
Book book2 = new Book("Повесть", "Петр Петров", 1975);
Book book3 = new Book("Ода", "Светлана Козлова", 1875);
Book book4 = new Book("Ода", "Светлана Козлова", 1877);
Book book5 = new Book("Азбука", "Артем Кошкин", 2000);
Book book6 = new Book("Букварь", "Евгений Томин", 1956);
Library library = new Library();
library.Add(book1);
library.Add(book2);
library.Add(book3);
library.Add(book4);
library.Add(book5);
library.Add(book6);
library.Print();
//library.SearchName("Сказка");
//library.RemoveBook("Повесть");   //Удаление по имени
//library.RemoveIndex();   //Удаление по номеру в списке
library.SortByName();
library.SortByAuthor();
library.SortByYear();
library.Print();
