// declare variables
Console.Write("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your first name: ");
string firstName = Convert.ToString(Console.ReadLine());

Console.Write("Please enter your last name: ");
string lastName = Convert.ToString(Console.ReadLine());

// calculate retirement age
int retirementAge = 65 - age;


// print to console
Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine("");
Console.WriteLine($"Working years remaining: {retirementAge}.");

Console.ReadKey();
