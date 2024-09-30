namespace Models;

public interface IPerson
{
    string FirstName { get; set;}
    string LastName { get; set;}
}

public interface ICar
{
    string RegNr { get; set;}
    IPerson Owner {get; set;}
    int Year { get; set;}
}