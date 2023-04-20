using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//* Interfaces -> These are "contracts"
//* If this is assigned, it MUST BE IMPLEMENTED
//* ALWAYS STARTS WITH THE LETTER "I" and then the word (IFruit, Ifruitable)
//* Interfaces ARE ALWAYS PUBLIC
public interface IFruit
{
    string Name {get;}  //getter (read only)
    bool isPeeled {get;} //getter (read only)
    string Peel();  //method that returns a string value
}
