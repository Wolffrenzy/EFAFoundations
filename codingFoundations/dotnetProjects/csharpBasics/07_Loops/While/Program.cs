//* While Loop


// for (int i = 0; i < number; i++)
// {
//     System.Console.WriteLine(i);
// }

//set up a while loop
int number = 0;

//boolean expression
while(number <= 100)
{
    //do some work
    System.Console.WriteLine(number);
    //! WE NEED A WAY OUT OF HERE!! NO INFINITE LOOPS
    number+=5;
}

//Infinite loops ctrl+c to stop an infinite loop in the terinal
//while(number == 0)
// {
//     System.Console.WriteLine("oh, crap");
// }

//? what about 'break and continue' ... and return

int value2 = 100;

while (value2 > 0)
{
    value2--;   //value2 = value2 - 1;
    if (value2 == 90)
    {
        System.Console.WriteLine($"{value2}, We're jumping out of this loop!");
        break;  //this makes us jump out of the while loop
    }
    if (value2 == 80)
    {
        System.Console.WriteLine($"{value2}, we'll just return (leave the loop)");
        return;
    }
    if (value2 == 10)
    {
        System.Console.WriteLine($"{value2}, We'll just carry on with the loop");
        continue;
    }
}