// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string Cali = "Supercalifragilisticexpialidocious";
foreach (char c in Cali)
{
    Console.WriteLine(c);
}

foreach (char c in Cali)
{
    if (c == 'i')
    {
        Console.WriteLine(c);

    }
    else if (c == 'l')
    {
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine("Not an i, or l.");
    }
    // switch (c)
    // {
    //     case 'i':
    //     case 'l':
    //         Console.WriteLine(c);
    //         break;
    //     default:
    //         Console.WriteLine("Not an i or l.");
    //         break;
    // }
};

Console.WriteLine(Cali.Length);
//    iterator; condition       ; what happens after each interation
for (int i = 0; i < Cali.Length; i++)
{
    // get the character at the index of i in word
    char c = Cali[i];
    string output = c == 'i' || c == 'l' ? c.ToString() : "Not an i or l.";
    //      string output = (c == 'i' || c == 'l')   //condition
    //      ? c.ToString()                           //what to return for true
    //      : "Not an i or l.";                      //what to return for false
    Console.WriteLine(output);
}