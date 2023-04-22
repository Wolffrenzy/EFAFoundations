//Dependency Injection
//Forces us to have 'loosely coupled code'.
//We want to inject object from the outside

public interface ICurrency
{
    string Name {get;} //! ONLY A GETTER SO NOBODY CAN CHANGE NAMES

    decimal Value {get;}
}