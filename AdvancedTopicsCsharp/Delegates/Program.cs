// See https://aka.ms/new-console-template for more information

//delegate is an object that knows how to call a method or a group of methods
//in other words, reference or a pointer to a function.
//with this functionally we can create application flexible and extensible.

using Delegates;

var processor  = new PhotoProcessor();
var filters = new PhotoFilters();

PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += ExtensionFilters.RemoveRedEyeFilter;

processor.Process("photo.png", filterHandler);