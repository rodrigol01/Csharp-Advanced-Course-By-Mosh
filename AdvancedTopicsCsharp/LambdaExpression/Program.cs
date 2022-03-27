// See https://aka.ms/new-console-template for more information

//anonymous method that don't have access modifier, no name, no return statement
//arges => expression
//number => number * number

// () => ...
// x => x...
//(x,y,z) => ...

//basic example

using LambdaExpression;

const int factor = 5;

Func<int, int> multipler = n => n * factor;

var result = multipler(2);

Console.WriteLine(result);

//other example

var books = new BookRepository().GetBooks();

var findCheapBooks = books.FindAll(IsCheaperThan10Dollars);
foreach (var book in findCheapBooks)
{
    Console.WriteLine(book.Title + " Price: " + book.Price);
}

//using the lambda expression directly
var findExpensiveBooks = books.FindAll(book => book.Price >= 10);
foreach (var book in findExpensiveBooks)
{
    Console.WriteLine(book.Title + " Price: " + book.Price);
}

//delegate method of type PREDICATE method (when it returns a boolean)
static bool IsCheaperThan10Dollars(Book book)
{
    return book.Price < 10;
}
