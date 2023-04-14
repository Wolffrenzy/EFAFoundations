//* ForEach
//syntax:

/*
    forEach(declaredIterator in enumerableCollection)
    {
        body
    }
*/

//ex:
string instructorName = "Amanda";

//make an enumerable collection
string[] instructorName = new string[] {"Michael", "Joshua", instructorName};

//Let's loop
foreach(string instructor in instructors)
{
    System.Console.WriteLine(instructor);
}

//we want a collection of integers
//and we want to print out if the integer is pos or neg
int[] intArray = new int[] { 1, 2, -3, 4, 5, 0};

foreach (int value in intArray)
{
    if(value < 0)
    System.Console.WriteLine("This is a Negative Number.");
    else if(value > 0)
    System.Console.WriteLine("This is a Positive Number.");
    else
    System.Console.WriteLine("This is a Neutral Number");
}