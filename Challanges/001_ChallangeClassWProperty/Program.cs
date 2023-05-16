using UserClassChallenge;
//Objects
User user1 = new User(001, "Brainne", "Wilson");
// User user1 = new User(id: 001, firstName: "Brainne", lastName: "Wilson");
user1.MiddleName = "Elizabeth";

Birthday bday = new Birthday(5, 12, 1980);
user1.Birthday= bday;

DescribeUser(user1);//invoking the DescribeUser function

int userCounter = 2;

// Ask the user for the firstname
Console.WriteLine("What is your first name?");
string firstName = Console.ReadLine() ?? "User";

// Ask the user for the lastname
Console.Write("Enter your last name: ");
string lastName = Console.ReadLine() ?? userCounter.ToString();

// Ask for the birth yaer
Console.Write("Enter your birth year: ");
string yearResponse = Console.ReadLine() ?? "0";//always returns a string, must convert
int birthYear = int.Parse(yearResponse);
birthYear = Convert.ToInt32(yearResponse);
// Birthday birthday = new Birthday(userCounter, firstName, birthYear);
// consoleUser.Birthday = birthday;

// consoleUser.Birthday.Year


// created a user instance called consoleUser
// new variable of type user
User consoleUser = new User(userCounter, firstName, lastName);
DescribeUser(consoleUser);

//the following are not good =(
// User createUser = new User(Console.ReadLine())
// User.FirstName = Console.ReadLine(userName);
// User.LastName = new User Console.ReadLine(UserLastName);
// User.Id = new User Console.ReadLine(UserId); 
//break.


// Top Level function
// only writes to the console, does not return a value, void is the return type.
void DescribeUser(User user)
{
    // string description = $"user #{user.Id} is {user.FirstName} {user.LastName}.";
    string description = $"user #{user.Id} is {user.Name}.";
    Console.WriteLine(description);
    Console.WriteLine($"Their full name is {user.GetFullName()}");
    Console.WriteLine($"Their birthday is {user.Birthday?.Month}/{user.Birthday?.Day}/{user.Birthday?.Year}");
}



namespace UserClassChallenge
{
    internal class User
    {
        // Constructor
        public User(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        private string _UserInformation;
        internal User(string type)
        {
            this.FirstName = type;
        }

        //Properties
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }

        public string LastName { get; set; }
        public int Id { get; } // read-only property
        public Birthday? Birthday { get; set; }

        public string Name
        {
            get
            {
                //string concatenation
                string fullName = FirstName + " " + LastName;
                return fullName;
            }
        }

        //Methods
        public string GetFullName()
        {
            //string array
            string?[] names = { FirstName, MiddleName, LastName };

            // string fullName = $"{FirstName} {MiddleName} {LastName}";
            string fullName = string.Join(" ", names.OfType<string>());
            return fullName; //returns a string based on the previous properties;
        }
    }
    class Birthday
    {
        // Constructor
        public Birthday(int month, int day, int year)
        {
            //property = parameter;
            Month = month;
            Day = day;
            Year = year;

        }
        //Day, Month, Year.
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

    }


}
