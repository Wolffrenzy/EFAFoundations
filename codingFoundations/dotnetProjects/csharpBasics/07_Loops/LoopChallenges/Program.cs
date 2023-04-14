//Loops Challenges:

//Bronze:
//Write a for loop to print the numbers 500 through 525.
//starting point i = 500; (initialization)
for (int i = 500; i <= 525; i++)
{
    System.Console.WriteLine(i);
}
//boolean expression i<=525 (the loop will run as long as this is TRUE)
//i will increment up by one as long as bool value is TRUE
System.Console.WriteLine("=====Silver Challenge=====");
//Silver:
//Create a for loop to print the numbers from 0-100 by 5's.
for (int i = 0; i <= 100; i+=5)
{
    System.Console.WriteLine(i);
}

//Gold:
//Create a for loop to print the numbers 1-100. 
for (int i = 1; i <= 100; i++)
{
//If it's divisible by both 3 and 5, print 'FizzBuzz' otherwise print the number.
    if((i % 3 == 0) && (i % 5 == 0))
    {
    System.Console.WriteLine($"{i}: FizzBuzz");
    }
//If the number is divisible by 3, print 'Fizz' instead of the number. 
    else if( i % 3 == 0)
    {
    System.Console.WriteLine($"{i}: Fizz");
    }
//If it's divisible by 5, print 'Buzz', instead of the number.
    else if( i % 5 == 0)
    {
    System.Console.WriteLine($"{i}: Buzz");
    }
    else 
    {
    System.Console.WriteLine($"{i}: Undefined");
    }
}