using System;

namespace PolymorphismAssignment
{
// 1. Create the interface called IQuittable
interface IQuittable
{
// Define a void method called Quit
void Quit();
}

// 2. Have the Employee class inherit the interface
// The colon (:) means Employee is following the IQuittable rules
public class Employee : IQuittable
{
public string Name { get; set; }

// We must implement the Quit method here to satisfy the interface
public void Quit()
{
Console.WriteLine(Name + " has submitted their resignation.");
}
}

class Program
{
static void Main(string[] args)
{
// 3. Use polymorphism to create an object of type IQuittable
// We use the Interface name as the type, but the Class to create it
Employee emp= new Employee() {Name = "Arjun" };

// Call the Quit() method on the interface object
emp.Quit();

// 4. Adding a simple line to keep the window open so we can read it
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
}
}
}

