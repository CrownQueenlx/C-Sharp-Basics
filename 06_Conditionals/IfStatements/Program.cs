bool isRaining = true;
bool isGoingOutSide = true;

/*
If statement Syntax
if (true/false value or expression)
{
    Curley braces on a new line

    Body on code to be executed if the condition is true
}
*/

if (isRaining)
{
    Console.WriteLine("It is raining.");
}

// If is rainging AND we are going outside
if (isRaining && isGoingOutSide)
{
    Console.WriteLine("Better bring an umbrella.");
}

// Is not rainging OR We are not going outside
if (!isRaining || !isGoingOutSide) 
{
    Console.WriteLine("I do not need an umbrella.");
}

// Exclusvely raining or we are going outside.
if (isRaining ^ isGoingOutSide) 
{
    Console.WriteLine("I will only go outside if it is not raining.");
}

// If it is not raining, cut the grass, if it is raining don't cut the grass
if (isRaining) // True
{
    //..
}
if (!isRaining) // False
{
    //..
}    
if (!isRaining)
{
    Console.WriteLine("I will go cut the grass.");
}
else
{
    Console.WriteLine("I will not cut the grass.");
};

Console.WriteLine("How are you feeling on a scale of 1-5?");
string? rating = Console.ReadLine();
string five = "5";
string four = "4";
string three = "3";
string two = "2";
string one = "1";
int numOne = int.Parse(one);
int numTwo = int.Parse(two);
int numThree = int.Parse(three);
int numFour = int.Parse(four);
int numFive = int.Parse(five);
int numRating = int.Parse(rating);
// double notInt = 
string parameters = "Your response does not match our conditions.";

if (numRating == numOne)
{
    Console.WriteLine("Dang. We hope your day gets better!");
}
else if (numRating == numTwo)
{
    Console.WriteLine("Oh. Sorry to hear that.");
}
else if (numRating == numThree)
{
    Console.WriteLine("Hope things improve!");
}
else if (numRating == numFour)
{
    Console.WriteLine("Good stuff!");
}
else if (numRating == numFive)
{
    Console.WriteLine("That's great to hear!");
}
else if (numRating>5 && numRating < 0)
{   
    Console.WriteLine(parameters);
}
else
{
    Console.WriteLine(parameters);
}



bool hasUmbrella = (isGoingOutSide && isRaining);

if (hasUmbrella == true)
{
    Console.WriteLine("Good thing I have my umbrella so I can go outside while it's raining!");
}

// If else example vased on the one condition, isGoingOutside
if (isGoingOutSide)
{
    Console.WriteLine("Make sure to dress for the weather!");
}
else
{
    Console.WriteLine("Sounds like a sweats kind of day.");
}