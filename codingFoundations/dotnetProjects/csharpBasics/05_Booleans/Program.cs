//* Booleans

//Can hold true or false

bool isCool = false;

//bool and logical operators
//keywords:
//todo: AND, OR, NOT, etc.

//todo: NOT
//* C# logical Negation Operator, called the 'bang' operator (!)
//? !isCool, evaluates to the opposite of what it is declared.
System.Console.WriteLine(!isCool);

//todo: AND
//* C# uses ampersands (&) to indicate AND statements
//* A single ampersand evaluates both conditions always,
//* A double ampersand evaluates onl the right side if required.

//todo: OR
//* C# uses pipes (|) to indicate OR statements
//* A single pipe evaluates both conditions always,
//* Two pipes evaluates the left side then the right side

//todo: XOR
//* C# uses the carat (^) to indicate XOR statements

//? Examples
//todo: Negation Operator
bool isTrue = !false; //This will return true
bool isFalse = !true; //this will return false

//todo: AND operator
bool trueAndExample = true && true; //true -> both of these have to be true
bool falseAndExample = true && false; //false

//todo: OR operator
bool trueOrExample = true || false; //true -> b/c only one has to be true.
bool falseOrExample = false || false; //

//todo: XOR operator
bool trueExclusiveOr = true ^ false;    //true
bool falseExclusiveOr = true ^ false;   //false
bool falseExclusiveOr2 = false ^ false;  //false

System.Console.WriteLine($"NOT False = {isTrue}");
System.Console.WriteLine($"False AND True = {falseAndExample}");
System.Console.WriteLine($"True OR True = {trueOrExample}");
System.Console.WriteLine($"True XOR True = {trueExclusiveOr}");
System.Console.WriteLine($"False XOR False = {falseExclusiveOr2}");

//ComparisonOperators

//Equal, ==

//Not equal, (!=)

//Greater Than (>)

//Less Than (<)

//Greater Than or Equal (>=)
//Less Than or Equal (<=)

bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
System.Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");

bool isLessThan = 5 < 5; 
bool isLessThanOrEqualTo = 5 <= 5;
System.Console.WriteLine($"5 < 5 is {isLessThan}, while 5 <= 5 is {isLessThanOrEqualTo}");

              //1   2.
bool equality = 17 == 9;
bool inequality = 17 != 9;
System.Console.WriteLine($"17 == 9 and 17 != 9 are {equality} and {inequality}, respectively.");
//1 Assignment Operator
//2 Boolean Expression