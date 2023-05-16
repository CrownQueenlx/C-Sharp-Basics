namespace Classes;

public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Boat, Plane }
// accessModifier class ClassName
public class Vehicle
{
    //Constructor Overloading
    public Vehicle()
    {
        Make= "Default";
        Model = "Default";
        Color = "Default";
        TypeOfVehicle = VehicleType.Car;
    }
    public Vehicle(string make, string model, string color, VehicleType type)
    {
        // Property = parameter
        Make = make;
        Model = model;
        Color = color;
        TypeOfVehicle = type;
    }
    // Properties
    // Make, Model, Milage, Color
    // accessModifier, type, name { accessors; }
    public string Make { get; set; }
    public string Model { get; set; }
    public double Milage { get; set; }
    public string Color { get; set; }
    public VehicleType TypeOfVehicle { get; set; }

    // Property with a private set (only change it in the class)
    public bool IsRunning { get; private set; }

    public Indicator RightIndi { get; } = new Indicator("right");
    public Indicator LeftIndi { get; } = new Indicator("left");
    // Methods (Actions)
    // accessModifier returnType Name(parameters)
    public void TurnOn()
    {
        if (!IsRunning) //(IsRunning == false)
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }
        else
        { // {IsRunning = true;
            Console.WriteLine("The vehicle is already on.");
        }
    }
    public void TurnOff()
    {
        if (IsRunning) //IsRunning == true
        {
            IsRunning = false;
            Console.WriteLine("You turn the vehicle off.");
        }
        else
        {
            Console.WriteLine("The vehicle is already off.");
        }
    }

    // Indicate Right
    public void IndicatRt()
    {
        if (IsRunning && !RightIndi.IsFlashing)
        {
            RightIndi.TurnOn();
            LeftIndi.TurnOff();
        }
    }
    // Indicate Left
    public void IndicateLt()
    {
        if (IsRunning && !LeftIndi.IsFlashing)
        {
            LeftIndi.TurnOn();
            RightIndi.TurnOff();
        }
    }
    // Turn on Hazards
    public void TurnOnHazards()
    {
        RightIndi.TurnOn();
        LeftIndi.TurnOn();
    }
    // Clear all indicators
    public void ClearIndis()
    {
        RightIndi.TurnOff();
        LeftIndi.TurnOff();
    }
}

