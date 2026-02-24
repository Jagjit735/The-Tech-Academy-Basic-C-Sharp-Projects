using System;

class Program
{
static void Main(string[] args)
{
// Assignment Part 1

// I am using an array of cars for this part
string[] cars = { "Ford ", "Toyota ", "Tesla ", "Verna " };

//  Asking the user for descriptor
Console.WriteLine(" Verna is my favourite car:");
string userDescriptor = Console.ReadLine();

//  A loop that iterates through each car and adds the user's text
for (int i = 0; i < cars.Length; i++)
{
cars[i] = cars[i] + userDescriptor;
}

//  A second loop that prints the updated car list
Console.WriteLine("\nDisplaying updated car list:");
foreach (string car in cars)
{
Console.WriteLine(car);
}

// Keeping the console open 
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();// --- Assignment Part 2 ---

//  Creating a loop
// I am using a variable called 'timer'
int timer = 0;
Console.WriteLine("\nStarting Part 2:");
//  Fix the infinite loop so that it  executes properly
while (timer < 3)
{
Console.WriteLine("The timer is at:" + timer);
//  it was fixed:This line adds 1 to the timer each time.
// Without the timer++', this loop would stay at 0 and runs  forever.
timer++;
} 
// --- Assignment Part 3 ---
//  Loop using the "<" operator
Console.WriteLine("\n--- Part 3: Using < operator ---");
int score = 0;
while (score < 3)
{
Console.WriteLine("Score is: " + score);
score++;
}
//  Loop using the "<=" operator
Console.WriteLine("\n--- Part 3: Using <= operator ---");
int level = 0;
while (level <= 3)
{
Console.WriteLine("Level is: " + level);
level++;
}
// --- Assignment Part 4 ---
List<string> teams = new List<string> { "Nona", "Avtar", "Gagan", "Preet" };

Console.WriteLine("\nEnter a team name to search:");
string search = Console.ReadLine();

bool found = false;

for (int i = 0; i < teams.Count; i++)
{
if (teams[i] == search)
{
Console.WriteLine("Found at index: " + i);
found = true;
break;
}
}

if (found == false)
{
Console.WriteLine("Not on the list.");
}
// --- Assignment Part 5 ---
List<string> names = new List<string> { "Nona", "Avtar", "Gagan", "Nona", "Preet" };

Console.WriteLine("\nEnter a name to search for duplicates:");
string nameSearch = Console.ReadLine();

bool nameFound = false;

for (int j = 0; j < names.Count; j++)
{
if (names[j] == nameSearch)
{
Console.WriteLine("Match found at index: " + j);
nameFound = true;
}
}

if (nameFound == false)
{
Console.WriteLine("Not on the list.");
}
// --- Part 6 ---
List<string> items = new List<string> { "Nona", "Avtar", "Nona", "Gagan" };
List<string> seenItems = new List<string>();

Console.WriteLine("\nChecking for duplicates:");

foreach (string item in items)
{
if (seenItems.Contains(item))
{
Console.WriteLine(item + " - duplicate");
}
else
{
Console.WriteLine(item + " - unique");
seenItems.Add(item);
}
}



}
}








