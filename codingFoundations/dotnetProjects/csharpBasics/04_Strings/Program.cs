//* Strings

/*
*Just a collection of characters, and they are stored and used throughout the entire application
*Almost any text, single character, or number can be a string


todo: In C# we can initialize a string by using ("") wrapped around the value

todo: 3 ways to use a string type
    ? Concatenation
    ? Composite Formatting
    ? Interpolation
*/

//Concatenation Example:
string first = "The cars we sell are";
string second = "BMW, Lexus, and Mercedes.";
string concatenatedResult = first + ' ' + second;
System.Console.WriteLine(concatenatedResult);

//Composite Formatting:
string firstName = "Gabriel";
string lastName = "Wolf";

string compositeResult = string.Format("His name is {0} {1}",firstName,lastName);
System.Console.WriteLine(compositeResult);

//String Interpolation
string interpolationResult = $"His name is still {firstName} {lastName}.";
System.Console.WriteLine(interpolationResult);