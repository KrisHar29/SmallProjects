
using ExtensionMethods;
using System;


//Create two extension methods. One called Print that
//prints a string to the console like so:
//“HelloWorld”.Print() and one called Excite that
//replaces all periods with exclamation points like so:
//“Hello World.”.Excite()

string test = "This is a test.";

test.Print();

test.Excite();
test.Print();

//Create this chain for a Person object:
//<person>.Fill().Print(); where Fill asks the user for each
//property’s value and print will print all properties to
//the console. Then create this chain on a double:
//<double>.Add(4).Subtract(2).MultiplyBy(8).DivideBy(3);

PersonModel person = new PersonModel();
person.Fill().Print();

double number = 10;

Console.WriteLine(number.Add(1).Multiply(5).Subtract(5).Divide(2));


Console.ReadLine();