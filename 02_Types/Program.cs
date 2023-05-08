// bool is a true false value, with no quotes
bool isAwake = true;
Console.WriteLine(isAwake);

// Interger, or int, are whole numbers
int age = 31;
Console.WriteLine(age);

//double is a decimal type (32bit)
double notAWholeNumber = 42.5;
double withASuffix = 37.1d;
Console.WriteLine(notAWholeNumber + withASuffix);

// Float is also a decimal type (16bit)
float anotherDecimal = 3.14f;
Console.WriteLine(anotherDecimal);

// Decimal is a very precise decimal (64bit)
decimal aLargeDecimal = 8.33333333333333m;
Console.WriteLine(aLargeDecimal);

//3.1415926535897932384626433832795028841971
Console.WriteLine("Float:" + 3.1415926535897932384626433832795028841971f);
Console.WriteLine("Double:" + 3.1415926535897932384626433832795028841971d);
Console.WriteLine("Decimal:" + 3.1415926535897932384626433832795028841971m);

//Strings (colleections of characters)
//Strings in C# use double quotes only
string myName = "Brianne";

// Characters (char)
// Single character, number, symbol, ect.
// Characters use single quotes
char mander = '4';
char space = ' ';
char symbol = '@';
char escapeCharacter = '\n';
Console.WriteLine(escapeCharacter + symbol + mander + space + " ");
Console.WriteLine(myName);