//what happens if an 'if' statement conditions aren't met.
bool isRaining = true;

//Example
if(!isRaining)
{
    System.Console.WriteLine("I'll go cut the grass!");
}
else //default -> if all else fails...we do this
{
    System.Console.WriteLine("I'm staying in bed...Yay!");
}

System.Console.WriteLine("---------------------------");

if(!isRaining)
{
    System.Console.WriteLine("I'll go cut the grass!");
}
if(isRaining) 
{
    System.Console.WriteLine("I'm staying in bed...Yay!");
}

System.Console.WriteLine("------------ if / else -------------");

bool isGoingOutside = true;

if(isGoingOutside) //isGoingOutside == True
{
    System.Console.WriteLine("Please dress for the weather.");
}
else
{
    System.Console.WriteLine("Seems like a sweats kind of day");
}

System.Console.WriteLine("------------ if/else if/else if/else -------------");

if(isGoingOutside)
{
    System.Console.WriteLine("Please dress for the weather.");
}
else if(isGoingOutside && isRaining)
{
        //do some code
        System.Console.WriteLine("I'm running outside shirtless");
}
else if(isRaining)
{
        //do some other code
        System.Console.WriteLine("Man, it's raining cats and dogs");
}
else
{
    System.Console.WriteLine("Seems like a sweats kind of day");
}

System.Console.WriteLine("------------ more if/else -------------");

//Ask the user how they are feeling
System.Console.WriteLine("How are you feeling (1-5) ? ");

//we need to get 'user input' Console.ReadLine(string value)

string value = Console.ReadLine();

// int intValue = int.Parse(value);

//if...else/if
if(value == "1")
{
    System.Console.WriteLine("Dang, we hope your day get's better!");
}
else if(value == "2")
{
    System.Console.WriteLine("Oh, sorry to hear that");
}
else if(value == "3")
{
    System.Console.WriteLine("I hope thing get better!");
}
else if(value == "4")
{
    System.Console.WriteLine("Good stuff");
}
else if(value == "5")
{
    System.Console.WriteLine("That's great to hear!");
}
else
{
    System.Console.WriteLine("Invalid Key entry");
}