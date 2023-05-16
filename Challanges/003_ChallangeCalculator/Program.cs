using Classes;
// type    name = new constructor()
Calculator calc = new Calculator();
int total = calc.sum(16, 42);
double totald = calc.sum(16.3, 21.4);
total = calc.difference(total, 5);
total = calc.product(total, 9);
total = calc.dividend(total, 2);
Console.WriteLine(total);

total = calc.difference(total, 5);

// calc.x = 6;//these need to be read in from the user.
// calc.y = 9;
// I need to read-in the numbers and operations from the user then return the readline values.

//Just for kicks.
// Console.WriteLine(calc.sum());
// Calculator c2= new Calculator();
// c2.x=2;
// c2.y=7;

// Console.WriteLine(c2.randomSum(calc.sum(),c2.sum()));


namespace Classes
{
    public class Calculator
    {
        // public int x { get; set; }
        // public int y { get; set; }
        // public int randomSum(int num1, int num2)
        // {
        //     return num1+num2;
        // } 

        // Addition method
        public int sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
          public double sum(double x, double y)
        {
            double sum = x + y;
            return sum;
        }
        // Subtraction method
        public int difference(int x, int y)
        {
            int difference = x - y;
            return difference;
        }
        public int product(int x, int y)
        {
            int product = x * y;
            return product;
        }
        // public int Multiply(int x, int y) => x * y;
        public int dividend(int x, int y)
        {
            int dividend = x / y;
            return dividend;
        }
        //you need methods here
        //you need return types
        // need to name it
        // need parameters
    }
}



/*
access modifier greturnType Name(paramType paramName) {method body}
*/

/*
public int Add(int numOne, int numTwo)
{
    int sum = numOne + numTwo;
    return sum;
}
*/