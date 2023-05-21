
// Creating an intitial target
int number = 100;

// 1    //2       //3        //4
for (int i = 0 ; i < number; i++)
{
    // 5
    Console.WriteLine(i);
}

// 1 - for keyword
// 2 - Declaration and initialization of an iterator variable
// 3 - Boolean expression comparing the new interatior to the number varible
// 4 - Incrementing the iterator at the end of each loop
// 5 - Body of the loop, runs once per iteration after the boolean is evaluated

Console.Write("Input a number to count to from zero "); 
string Input = Console.ReadLine() ?? "0";
int baseNum = int.Parse(Input);
baseNum = Convert.ToInt32(Input);

int numberInput = baseNum;

// 1    //2       //3        //4
for (int i = 0 ; i <= numberInput; i++)
{
    // 5
    Console.WriteLine(i);
}
