using Classes; // using directive

// type, name = new type constructor
Donut Sprinkles = new Donut("Sprinkles");// declare instance of Donut which uses the using statement to access the donut class
Classes.Donut Cream = new Classes.Donut("Cream"); //without the "using" directive you need explicit class directive

// Assigning a value to donutType field
// Sprinkles.donutType = "Sprinkles Donut";
Sprinkles.GetDonutType();
string flavor = Cream.GetDonutType();
Console.WriteLine(flavor);
Console.WriteLine(Sprinkles.GetDonutType());
// cream.donutType = "chocolate cream"
Cream.setDonutType("Chocolate Cream");
Console.WriteLine(Cream.GetDonutType());


Cream.Filling = "Strawberry"; // set
Console.WriteLine(Cream.Filling); // get


Cream.Topping = "cinnamon sugar"; //set
Console.WriteLine(Cream.Topping); //get

Cream.IsOnSpecial = false;
Cream.Price = 2.75;


namespace Classes
{
    class Donut
    {
        // Field, a variable of any type declared inside of a class
        // The access modifier is our public/private
        private string donutFilling;
        //Backing Field to back a property
        //Starting fields with _ is a naming convention
        private string? _topping;

        // Constructor
        public Donut(string type)
        {   //assigning our constructor parameter to the field
            // whatever is passed into the constructor passes its value to the field
            donutFilling = type;
        }

        //Properties
        // public -> Access Modifier
        // .. string? -> Property type
        // Filling -> Property name
        // { get; set; } -> Accessors
        public string? Filling { get; set; }
        public double Price { get; set; }
        public bool IsOnSpecial { get; set; }
        public string? Topping
        {   
            // The function method that is executed when you read from the property
            get
            {
                return _topping;
            }
            set
            {   
                // property = "..." -> "..." is represented as value
                // Donut.Topping = value;

                _topping = value?.ToUpper(); //optional chaining
            }
        }
        // Method is a function inside an object
        // public -> Accesss Modifier
        // string -> return Type
        // GetDonutType -> Method name
        // () -> group of parameters, no params means it is empty
        // GetDonutType() -> Method Signature, must be unique -> name + parameters
        public string GetDonutType()
        {
            //Returns our above field
            return donutFilling;
            // return this.donutFilling = type (not conventional)
        }

        public void setDonutType(string newType)
        {
            donutFilling = newType;
        }
    }
}