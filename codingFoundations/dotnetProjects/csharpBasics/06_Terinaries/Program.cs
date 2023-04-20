//* Ternary Expressions (The ONE LINER CONDITIONAL)

// Conditional Operator

// Syntax
        //1          //2                   //3
// Boolean expression ? expression if true : expression if false

/*
*   1. Boolean expression to be evaluated
*   2. Seperates the boolean and the true result
*   3. Seperates the true/false results
*/

//EX:
System.Console.WriteLine("Enter your age: ");
string response = Console.ReadLine();     //gives back a string

int age = int.Parse(response);

//output:
string output = (age >= 18)? "You can vote!" : "You're too young to vote.";

//but we can explore:
//DON'T BE AFRAID TO FAIL..B/C..IT'S DEFINITELY PART OF THE PROCESS!!
// string output = (age >= 18)? "You can vote!" : (age >= 0 && age <= 10)? "Dude, you're still a child": "Man, I can't wait to vote";

System.Console.WriteLine(output);