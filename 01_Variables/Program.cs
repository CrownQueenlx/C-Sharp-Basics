// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Command Palette:
// Windows: Ctrl + shitf + P
// > OmniSharp: Restart OmniSharp

// Declaring variables

// C#: type name = "value";
string firstname = "Brianne";

// 1. The type is string
// 2. The variable name is firstName
// 3. = i sthe assignment operator
// 4. The value is "Brianne"

// ctrl + . is our quick fix shortcut

Console.WriteLine(firstname);
firstname = "Scott";
Console.WriteLine(firstname); //can change the value not the type

// Prompt the user for input
Console.WriteLine("What is your favorite color?");

// Capture the user's input/response
// ? indicates that the type is nullable (can be null)
string? color = Console.ReadLine();
Console.WriteLine("You said your favorite color is " + color);