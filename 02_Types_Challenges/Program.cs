int i = 24;
Console.WriteLine(i);

string PetName = "Ruby";
Console.WriteLine(PetName);

string does = "does silly things";

bool isHappy = true;
Console.WriteLine(isHappy);

float sharing = 3.14f;
double big = 5.3333333d;
decimal TooBig = 3.14152653599876876829374m;
ulong foul = 12378537848547942689;

Console.WriteLine(foul);
Console.WriteLine(sharing);
Console.WriteLine(big);
Console.WriteLine(TooBig);

string str = $"My kitty {PetName} {does}.";
string yaya = sharing + " " + does;
Console.WriteLine(str);
Console.WriteLine(yaya);

string year = "1992";
int yearNumber = int.Parse(year);
Console.WriteLine(yearNumber);

int anotherNumber = Convert.ToInt32(year);
Console.WriteLine(anotherNumber);