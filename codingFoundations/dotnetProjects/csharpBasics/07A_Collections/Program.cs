//* C# Collections (these are just collections)

//* Everything in C# is an object
object[] stuff = new object[5]; //This can only hold 5 objects

//Arrays start at 0
stuff[0] = "Gabriel";
stuff[1] = 1;
stuff[2] = 44.75f;
stuff[3] = "Bill Bob";
stuff[4] = new String("BLAH");

System.Console.WriteLine(stuff[4]);

//! DO NOT DO THE ABOVE CODE!!

//* We need type Safety

//* Array -> Collection and it's a FIXED SIZE collection!
//* let's pick on string
//* This is a collection of characters (char)
string stringExample = "Hello World";
System.Console.WriteLine(stringExample[5]);
System.Console.WriteLine(stringExample[3]);

//Array of type string
//these are really QUICK when it comes to READING THE DATA
//they are really slow when it comes to DATA MODIFICATION
// b/c there will always be a COPY not the ORIGINAL
// Object initialization
string[] stringArray =
{
    "Hello",
    "World",
    "Why",
    "is it",
    "Always",
    stringExample,
    "?"
};

string thirdItem = stringArray[3];
System.Console.WriteLine(thirdItem);    //is it

stringArray[0] = "Hello there.";
System.Console.WriteLine(stringArray[0]);

//-- List<T>
// System.Collection.Generic (using statement (goes to the top of the file....))
List<string> listOfStrings = new List<string>();
List<int> listOfIntegers = new List<int>();

//Lets add to listOfStrings...
listOfStrings.Add("The first string in our List");
listOfStrings.Add("The second string in our List");

System.Console.WriteLine(listOfStrings[0]);
System.Console.WriteLine(listOfStrings[1]);

//Let's add to the list of integers
listOfIntegers.Add(1111);
listOfIntegers.Add(2222);
listOfIntegers.Add(3333);

System.Console.WriteLine(listOfIntegers[2]);

//--Queues<T>
//* Think of a line at the grocery store
//* Whoever is the first in line, get's service first

//FIFO
Queue<string> firstInFirstOut = new Queue<string>();

//ADDING TO THE QUEUE
firstInFirstOut.Enqueue("I'm First!");
firstInFirstOut.Enqueue("I'm Second!");

//how do we see who is next in line
string seeWhosNext = firstInFirstOut.Peek();
System.Console.WriteLine($"Who is next in line: {seeWhosNext}");

//removing an item
string removedItem = firstInFirstOut.Dequeue();
System.Console.WriteLine($"Who just got removed: {removedItem}");

//make sure it got removed
string whoIsNextInLine = firstInFirstOut.Peek();
System.Console.WriteLine($"Who just got removed: {whoIsNextInLine}");
System.Console.WriteLine($"See who's next in line* Who is next in line: {seeWhosNext}");

// System.Console.WriteLine($"See who's next in line* Who is next in line: {seeWhosNext}");

//* -- Dictionaries <TKey, TValue> (key/value pair)
//* 1 can only be ONE KEY
Dictionary<int,string> keyAndValue = new Dictionary<int, string>();

//so how do we add to this
keyAndValue.Add(0,"First Value");
keyAndValue.Add(2,"Second Value");
// keyAndValue.Add(2,"Second Value to EXPLODE!!");

System.Console.WriteLine(keyAndValue[2]);

//Stack<T> - LIFO (last in first out)
Stack<string> stackOfStrings = new Stack<string>();

// how do we add
stackOfStrings.Push("First Plate, I'll be last.....");
stackOfStrings.Push("Second Plate, I'll be second...");
stackOfStrings.Push("Third Plate, I'll be first...");

System.Console.WriteLine(stackOfStrings.Peek());

//lets remove a plate
string firstPlate = stackOfStrings.Pop();
System.Console.WriteLine($"Gabe took the {firstPlate}");

System.Console.WriteLine(stackOfStrings.Peek());

// Other Collections
SortedList<int,string> sortedKeyAndValue = new SortedList<int, string>();
HashSet<int> uniqueList = new HashSet<int>();

//-------Random Number---------

Random rng = new Random();

//random number between 5 and 20
int randomNumber = rng.Next(5,21);
System.Console.WriteLine(randomNumber);