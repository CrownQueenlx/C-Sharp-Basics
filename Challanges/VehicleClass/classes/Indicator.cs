// Create a class called Indicator that has a property called IsFlashing
// IsFlashing should have a private set 
// The Indicator class also then needs the methods required
// to change the state of the IsFlashing Property (TurnOn, TurnOff)

namespace Classes;
public class Indicator
{
    private string _label; //Field
    public Indicator(string label) //constructor
    {
        _label = label;
    }
    public bool IsFlashing { get; private set; }
    public void TurnOn()
    {
        if (!IsFlashing)
        {
            IsFlashing = true;
            Console.WriteLine($"You turn on the {_label} indicator.");
        }
        else
        {
            Console.WriteLine($"Your {_label} indicator is already on.");
        }

    }
    public void TurnOff()
    {
        if (IsFlashing)
        {
            IsFlashing = false;
            Console.WriteLine($"You turn off the {_label} indicator.");
        }
        else
        {
            Console.WriteLine($"Your {_label} indicator is already off.");
        }
    }
}