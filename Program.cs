using System;

class Program
{
    // Create a const variable with the value 100 
    const int MaxValue = 100; 

    static void Main(string[] args)
    {
        // Create a variable using the "var" keyword
        var message = "Hello, World!";

        // Create a Person object using the chained constructors
        Person person = new Person("Bob", "Doe");  

        Console.WriteLine("Max Value: " + MaxValue);  // Print the value of the const variable
        Console.WriteLine("Message: " + message);  // Print the value of the var variable
        Console.WriteLine("Person's Name: " + person.GetFullName());  // Print the person's full name

        Console.ReadLine();  
    }
}

class Person
{
    // Define property for first name
    public string FirstName { get; set; }

    // Define property for last name
    public string LastName { get; set; }  

    // Constructor that takes first name and last name as parameters
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Method to get the person's full name
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}
