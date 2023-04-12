//todo: C# is a STRONGLY TYPED Language!
//todo: We have to specify our TYPES!

//1       //2   //3     //4
string firstName = "Gabriel";

//1 Type
//2 Variable Name
//3 Assignment Operator
//4 Value

System.Console.WriteLine(firstName);

//we can "ask questions"
System.Console.WriteLine("What is your favorite color?"); //C# HAS TO USE DOUBLE QUOTES

//we can give an answer
string color = Console.ReadLine();

//make a reply  -> string concatenation
System.Console.WriteLine("You said that your favorite color is: " + color);

//Ask what is your name
System.Console.WriteLine("What is your name?");

//reply
string myName = Console.ReadLine();

string reply = "My name is: " + myName;

System.Console.WriteLine(reply);