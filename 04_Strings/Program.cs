string first = "The cars we sell are";
string second = "BMW, Lexus, and Mercedes.";

string space = " ";

// concatenation (using the plus operator)
string concatenatedResult = first + space + second;

Console.WriteLine(concatenatedResult);


// Compsite Formatting (uses {} and indexes)
string firstName = "Brianne";
string lastName = "Barlow";

string CompsiteResult = string.Format("My name is {0}{1}{2}.", firstName, space, lastName);
Console.WriteLine(CompsiteResult);

Console.WriteLine("The name is {1}. {0} {1}.", firstName, lastName);

// String Interpolation(the one with the $sign)
string InterpolationResult = $"My name is still {firstName}{space}{lastName}!";
Console.WriteLine(InterpolationResult);