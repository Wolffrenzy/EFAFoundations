// Fields

// A variable that is created inside a class -> //? future reference these can be made inside of 'structs'
// It's also a 'Member' of the class

//? What does it contain:
//* Access modifier -> defines what pieces of code can use it
//* Public - Everyone has access
//* Private - Only the containing class has access
//* Protected - Only inheriting class has access
//* Internal - Only the assembly has access

using _08_Classes;

Donut donut1 = new Donut();
System.Console.WriteLine(donut1);
System.Console.WriteLine("-----");

donut1.donutType = "Jelly Filled";

namespace _08_Classes
{
    public class Donut
    {
        // Publically accessible string
            //* Type    //* Name
        public string? donutType;
    }
}