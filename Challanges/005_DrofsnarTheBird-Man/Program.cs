// This is the Drofsnar Game Challenge
// Turn the file into C#
string fileContent = File.ReadAllText("Drofsnar-game-sequence.txt");
Console.WriteLine(fileContent);

// Turn the C# string into an array sor we can iterate ocer it
string[] encounters = fileContent.Split(",");
Console.WriteLine(encounters);

// Declare the starting values
int points = 5000;
int lives = 3;
int vbhCount = 0; //vulnerable bird hunters
int extraLife = 0; //earned?

//Iterate over each interaction/encounter/bird

    // Each encounter calculate points, life, death

    //Specify file path

    // Create a streamReader object
    //Read the entire contents of the file

    //Display the point to the console
    // Console.WriteLine(fileContents);

foreach (string encounter in encounters)
{
    Console.WriteLine(encounter);
    //Switch Expression
    int pointsToAdd = encounter switch
    {   //caseValue => returnValue
        "bird" => 10,
        "CrestedIbis" => 100,
        "GreatKiskudee" => 300,
        "RedCrossbill" => 500,
        "Red-neckedPhalarope" => 700,
        "EveningGrosbeak" => 1000,
        "GreaterPrairieChicken" => 2000,
        "IcelandGull" => 3000,
        "Orange-belliedParrot" => 5000,
        _ => 0 //default
    };

    points += pointsToAdd; // points = points + pointsToAdd;

    // Calculate the Vulnerable Bird Hunter points
    if (encounter == "VulnerableBirdHunters")
    {
        int vbhPoints = vbhCount switch
        {
            0 => 200,
            1 => 400,
            2 => 800,
            3 => 1600,
            _ => 0
        };
        points += vbhPoints;
        vbhCount++;
        Console.WriteLine($"You have found {vbhCount} Vulnerable Bird Hunters.");
    }

    //get a bonus life at 10k points
    if (points / 10000 > extraLife)
    {
        lives++;
        extraLife++;
        Console.Write(points);
        Console.Write("You earned a life!");
    }

    // Invincable Bird Hunters
    if (encounter == "InvincibleBirdHunter")
    {
        lives--;
        //if you die end the loop
        if (lives == 0)//lives <1
        {
            break;
        }
    }
    // totalPoints == (points+)
}
    Console.WriteLine(points);
    Console.WriteLine(lives);