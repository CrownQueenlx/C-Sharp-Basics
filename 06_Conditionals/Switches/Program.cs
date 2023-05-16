// Switch Statements include:
/* switch key word, 
value being evaluated, 
case keyword, indicating the block of code to be executed if the value being checked matches
-the given case,
break keyword, indicating the end of a case
default keyword, which is used to establish code that will run if no other case matches the given value.
*/
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
switch (name)
{
    case "Pete":
    Console.WriteLine("Pete! We found you!");
        // Code that runs if the variable name has the value of "Pete"
        break;
    default:
    Console.WriteLine("Well, hello there!");
        // Code that runs for every other possible value for name
        break;
}

Console.WriteLine("How are you feeling today on a scale 1-5?");
string feelingRating = Console.ReadLine();
int todayRating = int.Parse(feelingRating);
switch (todayRating)
{
    case 5: // Checks to see if feelingRating has the value of "5"
    Console.WriteLine("That's great to hear!"); // Runs if the above case matches
    break; // Ends the code that runs if the above case is met
    case 4:
    Console.WriteLine("Good Stuff!");
    break;
    case 3:
    Console.WriteLine("Hope things improve!");
    break;
    case 2:
    Console.WriteLine("Oh. Sorry to hear that!");
    break;
    case 1:
    Console.WriteLine("Dang. We hope your day gets better!");
    break;
    default: // This is only used if none of the other cases are matches
    Console.WriteLine("Sorry, we don't understand. Please try again later.");
    break;
}



/* SWITCH EXPRESSIONS:
used to execute some process or code,
but are specifically used to create a value

components:
value, being evaluated
switch key word
a body that conatins "cases" called expression arms, denoted with {}
the comma separated expression arms made of three parts:
    the expected value, called a pattern
    A => "fat arrow"
    the actual expression or value to be returned
A discard pattern, donoted with an underscore (_), which is basically the default

conclude with semicolon (;)
*/
Console.WriteLine("How were you feeling yesterday on a scale of 1-5?");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput ??"0");

string response = yesterdayRating switch
{
    1 => "Dang. We hope your today is a better day!",
    2 => "Oh. Sorry to hear that!",
    3 => "Hopefully thinkgs will get better this week.",
    4 => "Good stuff!",
    5 => "That's great to hear!",
    _ =>  "That's off the charts!"
};

Console.WriteLine(response);


bool comparison = (yesterdayRating > todayRating);
string better ="better";
string worse = "worse";
string yesterday = "yesterday";
string today = "today";
string output;


if (comparison)
{
    output = string.Format("You were feeiling {0} {1} than {2}.", worse, today, yesterday);
}
else
{
    output = string.Format("You are feeiling {0} {1} than {2}.", better, today, yesterday);
}
 
Console.WriteLine(comparison);
Console.WriteLine(output);