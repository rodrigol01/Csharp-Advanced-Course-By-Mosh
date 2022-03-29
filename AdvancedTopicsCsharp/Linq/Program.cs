// See https://aka.ms/new-console-template for more information

using Linq;

var books = new BookRepository().GetBooks();

var cheapBooks = books.Where(x => x.Price < 10)
                    .OrderBy(x => x.Title)
                    .Select(x => x.Title);

foreach (var book in cheapBooks)   
    Console.WriteLine(book);
    //Console.WriteLine(book.Title + " " + book.Price);

var searchBookByTitle = books.SingleOrDefault(x => x.Title == "ADO.Net Web API");
Console.WriteLine(searchBookByTitle);

var searchFirstBookByTitle = books.FirstOrDefault(x => x.Title == "C# Advanced Topics");
Console.WriteLine(searchFirstBookByTitle);

var skipTake = books.Skip(2).Take(3);
//inumerable of books