//* Interfaces -> these are 'contracts'
//* if this is assigned it MUST BE IMPLEMENTED 
//* Always starts with the letter I and then the word (IFruit, IFruitable)
//* Interfaces are ALWAYS public!

public interface IFruit
{
    string Name { get; }  //getter (read-only)
    bool IsPeeled { get; } //gettter (read-only)
    string Peel();  //method that returns a string value
}