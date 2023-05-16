// // bool is a true false value, with no quotes
// bool isAwake = true;
// Console.WriteLine(isAwake);

// // Interger, or int, are whole numbers
// int age = 31;
// Console.WriteLine(age);

// //double is a decimal type (32bit)
// double notAWholeNumber = 42.5;
// double withASuffix = 37.1d;
// Console.WriteLine(notAWholeNumber + withASuffix);

// // Float is also a decimal type (16bit)
// float anotherDecimal = 3.14f;
// Console.WriteLine(anotherDecimal);

// // Decimal is a very precise decimal (64bit)
// decimal aLargeDecimal = 8.33333333333333m;
// Console.WriteLine(aLargeDecimal);

// //3.1415926535897932384626433832795028841971
// Console.WriteLine("Float:" + 3.1415926535897932384626433832795028841971f);
// Console.WriteLine("Double:" + 3.1415926535897932384626433832795028841971d);
// Console.WriteLine("Decimal:" + 3.1415926535897932384626433832795028841971m);

// //Strings (colleections of characters)
// //Strings in C# use double quotes only
// string myName = "Brianne";

// // Characters (char)
// // Single character, number, symbol, ect.
// // Characters use single quotes
// char mander = '4';
// char space = ' ';
// char symbol = '@';
// char escapeCharacter = '\n';
// Console.WriteLine(escapeCharacter + symbol + mander + space + " ");
// Console.WriteLine(myName);

/* Reference types
Variables that hold a reference rather than a value */

/*Array type[]
Collection of similarly typed items (strings example) */
string[] ourClass = {
    "Braulio",
    "Brianne",
    "Edwin",
    "Garrett",
    "Isaac",
    "Jackson",
    "Marla",
    "Shelby"
};
Console.WriteLine(ourClass.Length);

string[] sd167 = ourClass;
Console.WriteLine(sd167.Length);

//Read from an array index
Console.WriteLine(sd167[5]);

//Write to an array index
sd167[5] = "Jackson Lee";

Console.WriteLine(ourClass[5]);
Console.WriteLine(sd167[5]);


Bed myBed = new Bed();
myBed.NumberOfPillows = 6;
myBed.Color = "White";

// Assigns the reference that myBed holds to the variable thisBed
Bed thisBed = myBed;

Console.WriteLine(thisBed.Color);

myBed.Color = "Grey";

Console.WriteLine(thisBed.Color);
Console.WriteLine(myBed == thisBed);

Console.WriteLine($"A {thisBed.Color} bed with {thisBed.NumberOfPillows} pillows.");
Console.WriteLine($"A {myBed.Color} bed with {myBed.NumberOfPillows} pillows.");

thisBed = new Bed();
thisBed.Color = "Pink";
thisBed.NumberOfPillows = 2;
Console.WriteLine(myBed == thisBed);

/* Lists
An expandable collection in C# (like a javascript array)

Declare a list */
List<string> listOfStings = new List<string>();
List<int> listOfIntegers = new List<int>();

// Add to lists
listOfStings.Add("First sting for our list.");
listOfIntegers.Add(31415);

for (int i = 0; i < 1000; i++)
{
    listOfIntegers.Add(i);
}

// Get values for the list
string firstString = listOfStings[0];

listOfIntegers[0] = 12358;

//Remove from a list
listOfStings.Remove("First string for our list.");

foreach (string text in listOfStings)
{
    Console.WriteLine(text + ", ");
}

listOfIntegers.RemoveAt(0);


listOfIntegers.RemoveRange(60, 200);


listOfIntegers.RemoveAll(number => number % 2 == 0);

// foreach (int num in listOfIntegers)
// {
// Console.Write(num + ", ");
// }

//Queues
// Like a list but order matters
// First in first out manner (FIFO)
Queue<string> firstInFirstOutCollection = new Queue<string>();

// Add to a queue (Enqueue)
firstInFirstOutCollection.Enqueue("I'm first!");
firstInFirstOutCollection.Enqueue("I'm next!");

// Peek at the front of the queue without changing the queue
string first = firstInFirstOutCollection.Peek();
Console.Write(first);
Console.WriteLine(firstInFirstOutCollection.Count);

// Remove an item form the front of the queue
string removedItem = firstInFirstOutCollection.Dequeue();
Console.WriteLine(firstInFirstOutCollection.Count);

/* Stack
Stack is opposite of a queue
First In Last Out (Last In First Out)
*/
Stack<string> LastInFirstOut = new Stack<string>();
LastInFirstOut.Push("Add to the stack");
LastInFirstOut.Pop(); // Remove from the stack

/* Dictionary
 Key Value pair collections 
 Dictionary<KeyType, ValueType> name  = new Dictionary<KeyType, ValueType>(); */
Dictionary<int, string> KeyAndValue = new Dictionary<int, string>();

KeyAndValue.Add(7, "Agent");
KeyAndValue.Add(219, "Another String");

string valueSeven = KeyAndValue[7];
KeyAndValue[7] = "Orange";
Console.WriteLine(valueSeven);
Console.WriteLine(KeyAndValue[7]);


Dictionary<string, Bed> beds = new Dictionary<string, Bed>();
beds.Add("mine", myBed);
beds.Add("that one", thisBed);

string? myBedColor = beds["mine"].Color; //collects the value from the Dictonary reference
Console.WriteLine(myBedColor);

/* DateTime type */
DateTime birthday = new DateTime(1992, 8, 11);
DateTime todayDate = DateTime.Today; // date with defaulted time to zeros
DateTime nowTime = DateTime.Now; //to the milisec

TimeSpan age = nowTime - birthday;
Console.WriteLine(age.TotalDays / 360.25);


/* Enums
    A basic type that has a set number of values
    Associated by a theme if some sort
    Examples might be days of the week, months of th eyear, house of the day */
WeekDays day = WeekDays.Wednesday; //dot.notation
if (day == WeekDays.Saturday)
{
    Console.WriteLine("Yay!");
}

switch (day)
{
    case WeekDays.Monday:
    break;
    case WeekDays.Tuesday:
    break;
    case WeekDays.Wednesday:
    break;
    case WeekDays.Thursday:
    break;
    case WeekDays.Friday:
    break;
    case WeekDays.Saturday:
    break;
    case WeekDays.Sunday:
    break;
}


enum WeekDays { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
enum Months { Jan = 1, Feb, Mar, Apr, Dec = 12 }




class Bed
{
    public int NumberOfPillows { get; set; }
    public string? Color { get; set; }
}