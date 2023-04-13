//* Syntax
//value being evaluated, often a variable
//The switch keyword
//A body that contains the 'cases', called 'expression arms', denoted by braces {}
// A comma that is separated by the expression arms (made of 3 parts):

/*
*   1. The expected value, called a 'pattern'
*   2. A "fat arrow", it looks like (=>)
*   3. The actual expression to be returned
*   4. Have a discard pattern '_'
*/

System.Console.WriteLine("Please enter a userName: ");

string userName = Console.ReadLine();

string greeting = userName switch
{
    "Pete" => "Hello Pete",
    "pete" => "Hello pete",
    "Danny" => "Hello Danny",
    "danny" => "Hello danny",
    _ => "Who are you?"
};

System.Console.WriteLine(greeting);

System.Console.WriteLine("==================How Are You Feeling Refactor======================");

System.Console.WriteLine("How were you feeling yesterday (1-5) ?");
string ratingInput = Console.ReadLine();

//we transform ratingInput into an integer
int yesterdayRating = Convert.ToInt32(ratingInput);

string response = yesterdayRating switch
{
    1=>"Dang, We hope today is a better day.",
    2=>"Oh, Sorry to hear that!",
    3=>"Hopefully things will get better this week",
    4=>"Good Stuff",
    5=>"That's great to hear!",
    _=>"That's off the charts!!!!"
};

System.Console.WriteLine(response);
