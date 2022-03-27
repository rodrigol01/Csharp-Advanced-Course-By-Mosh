// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//allow us to add methods to an existing class
//without changing its source code, or creating
// a new class that inhetis from it

string post = "This is supposed to be a very long blog post blah blah blah...";

var shortenedPost = post.Shorten(5);

Console.WriteLine(shortenedPost);