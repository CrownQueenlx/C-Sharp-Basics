// Write a for loop to print the numbers 500 through 525.
for (int i = 500; i <= 525; i++)
{
    Console.WriteLine(i);
}

// Create a for loop to print the numbers form 0-100 by 5's

for (int i = 0; i < 100; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
    // else
    // {
    //     Console.WriteLine("");
    // }
}

/* Create a for loop to print the numbers 1-100. If the number is divisible by 3, print  instead of the number.
If it's divisible by 5, print , instead of the number. If it's divisible by both 3 and 5, print  otherwise print the number.*/

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}