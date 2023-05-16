//pattern layout (syntax) for ternary expression
//boolean expression ? expression if true : expression if false ;
/*
expression to be evaluated
The ?: conditional operator
The ? separates the boolean and true result
The : separates the true and false results
The expression to be evaluated and returned when the boolean is evaluated as true
The expression to be evaluated and returned when the boolean is evaluated as false
*/

// Here we're using Write instead of WriteLine
Console.Write("Enter you age: ");
string response = System.Console.ReadLine();
int age = int.Parse(response);

//1         //2             //3             //4
string output = age >= 18 ? "You can vote!" : "You're too young to vote.";

//1 - Variable to hold returned value
//2 - Boolean expression to be evaluated
//3 - Value to be returned if 2 is true
//4 - Value to be returned if 2 is false

Console.Write("Enter you age: ");
System.Console.ReadLine();
if (age >= 18)
{
    Console.WriteLine("You can vote!");
}
else
{
    Console.WriteLine("You're too young to vote.");
}


Console.WriteLine(output);