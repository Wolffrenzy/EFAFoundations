using System;
//C# Types

//? Value type (structs) -> Immutable (the literal value cannot be changed), the value of 4 will ALWAYS be 4
//? Default to 0

//Bool -> True/False (boolean)
//our vairables will be 'camelCasedToPerfection'
bool isLoggedIn = true;
System.Console.WriteLine(isLoggedIn);

//? Integers, or int -> these are whole numbers
int age = 31;
System.Console.WriteLine(age);

//decimal -> very precise (money)
//we need a suffix after the value (m,M)
decimal accountBalance = 9000.01m;
decimal accountBalance2 = 9000.01M; //period works for decimal
decimal accountBalance3 = 9000_01M; //underscore ALSO works for decimal
System.Console.WriteLine(accountBalance);


int i = 0;              //32-bit integer value
short sh = 32767;       //16-bit integer value
Int16 anotherShort = 32000;
byte by = 255;          //this is a group of binary digits (usually eight) operated on as a unit.

string s = "hey!";      //collection of characters
                        //this is a reference type (default to null)

string c = "i";         //represents a single character

string s2 = @"a:\NewFolder\something.jpg";  //@ to specify a directory
// string s2 = "a:\\NewFolder\\something.jpg";

bool b = false;         //true or false value

long L = 7;             //is a LARGE integer value. x2 more LARGE. 
                        // -9_223_372_036_854_775_808 to 9_223_372_036_854_775_807
                        //(nine quintillion two hundred twenty-three quadrillion three hundred seventy-two 
                        //trillion thirty-six billion eight hundred fifty-four million 
                        //seven hundred seventy-five thousand eight hundred seven)

decimal d = 99.999999m; //'m' 128-bit precision, has a range of 28-29 decimal places

double db = 7.800000d;  //'d' has 15-16 digit precision with a 64-bit size

float f = 10.8f;        //'f' stored in 32-bits, half the size of a double

int? ni = null;         //'?' after the type allows the value to be null (nothing)

//Dealing with Decimals
//we can type as many decimal places that we want for a given type
//but, things change during compile time (dotnet run....)
Console.WriteLine(1.2578907289045789789789789787897f);      //least precise
Console.WriteLine(1.2578907289045789789789789787897d);
Console.WriteLine(1.2578907289045789789789789787897m);

//Enums
//use our pastry types
PastryType myPastry = PastryType.Croissant;
System.Console.WriteLine(myPastry);
System.Console.WriteLine((int)myPastry);

PastryType anotherPType = PastryType.Cake;
System.Console.WriteLine(anotherPType);

//Dates...
DateTime Today = DateTime.Today;
System.Console.WriteLine(Today);

DateTime birthDay = new DateTime(2023,04,11);
System.Console.WriteLine(birthDay);

//?Reference type (class) -> 'Pointers', point to a specific location in memory. (heap) bin full of memory. (defaults to null)
