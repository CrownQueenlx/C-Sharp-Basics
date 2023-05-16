Console.WriteLine("Hello, tell us a friend's name.");
string? friendName = Console.ReadLine();
 
switch (friendName)
{   case "Josh" :
    Console.WriteLine("Best instructor at eleven fifty academy!");
    break;
    case "Garrett" :
    Console.WriteLine("He has an amazing sense of humor.");
    break;
    case "Isaac":
    Console.WriteLine("He's got this!");
    break;
    case "Marla":
    Console.WriteLine("Can't wait for lunch break!");
    break;
    case "Shelby":
    Console.WriteLine("Is a fighter!");
    break;
    case "Braulio":
    Console.WriteLine("Has great questions.");
    break;
    case "Edwin":
    Console.WriteLine("He just shared a link.");
    break;
    case "Jackson":
    Console.WriteLine("Is a ComputerWiz!");
    break;
    default:
    Console.WriteLine($"We're sorry, we don't know {friendName} yet.");
    break;
}