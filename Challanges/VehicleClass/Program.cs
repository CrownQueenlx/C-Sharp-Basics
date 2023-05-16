using Classes;

Vehicle myCar = new Vehicle();
Vehicle CRV = new Vehicle("Honda", "CR-V", "Dark Blue", VehicleType.Motorcycle);

myCar.TypeOfVehicle = VehicleType.Car;
myCar.Make = "GMC";
myCar.Model = "Conversion Van";
myCar.Milage = 300000;
myCar.Color = "Tan";

// myCar.IsRunning = true; cannot be set 
// becasue it is inaccessable in this context
myCar.TurnOn();
myCar.TurnOn();
Console.WriteLine(myCar.IsRunning);

myCar.TurnOff();
myCar.TurnOff();
Console.WriteLine(myCar.IsRunning);

myCar.TurnOnHazards();
myCar.ClearIndis();

myCar.TurnOn();
myCar.IndicatRt();