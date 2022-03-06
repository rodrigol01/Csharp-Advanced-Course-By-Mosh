// See https://aka.ms/new-console-template for more information

using Generics;

var listOfInt = new ListOfAnything<int>();
listOfInt.Add(2);

var listOfStrings = new ListOfAnything<string>();
listOfStrings.Add("Hi, I'm generic, performative, reused and productive");

var listOfBooks = new ListOfAnything<Book>();
listOfBooks.Add(new Book("The Little Prince", 1943));