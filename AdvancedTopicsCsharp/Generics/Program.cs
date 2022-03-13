// See https://aka.ms/new-console-template for more information

var number = new Generics.Nullable<int>();
Console.WriteLine("Has value? " + number.HasValue);
Console.WriteLine("Value? " + number.GetValueOfDefault());