// //* Properties -> Variables that are on an object that have the ability to tell the compiler if users
//                 //* can read/write to it.

// //* What makes properties different:
// //* Allows the variable to :
// //* Read
// //* Write
// //* Or Compute

// //* Allows us an easier approach to have safety w/n our application

// Donut doug = new Donut("Sprinkles");

// //* Use the "GetMethod"
// System.Console.WriteLine($"using GetMethod: {doug.GetDonutType()}");
// // doug.SetDonutType("Updated Sprinkles");
// System.Console.WriteLine($"using GetMethod: {doug.GetDonutType()}");


// public class Donut
// {
//     // Private backing field
//     private string? _donutType;

//     //Public property (everyone can use...)
//     //? Get -> Read (data)
//     //? Set -> Write to (data)
//     public string Filling { get ; set; }

//     // public Donut(string donutType)
//     {
//         _donutType = donutType;
//     }


//     //Make a method that will return the value
//     public string GetDonutType()
//     {
//         return _donutType;
//     }

//     public void SetDonutType()
//     {
//         _donutType = type;
//     }
// }
