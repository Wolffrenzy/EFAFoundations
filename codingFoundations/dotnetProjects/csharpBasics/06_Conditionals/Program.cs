//* Conditionals
//todo: handles making decisions in your application
//* Operates on specific conditions

//* EX:
// If the user is logged in, redirect them to the login page
//If it's the user's birthday, wish them happy birthday
//If the user doesn't have the required role, then deny them access

bool isRaining = true;
bool isGoingOutside = true;

//If statements:
//Formula:
//Given a boolean, if the boolean evaluates to 'true' then do the action given

//* If statement syntax:
// if(true/false value)
// {
//  body of the code, we'll execute this if the above value evaluates to true.
// }

//(isRaining == True)
if(isRaining)
{
    System.Console.WriteLine("It's raining out");
}

//Multiple if statements
//And
if(isRaining && isGoingOutside)
{
    System.Console.WriteLine("Better bring an umbrella.");
}

//OR
if(!isRaining || isGoingOutside == false)
{
    System.Console.WriteLine("I don't need an umbrella.");
}

//XOR
if(isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I will only go outside if it's not raining.");
}

//multi If statement
bool hasUmbrella = true;
if(hasUmbrella && isGoingOutside && isRaining)
{
    System.Console.WriteLine("Good thing I have my umbrella, so that I can go outside, while it's raining!");
}