// declare variables
Console.Write("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your name: ");
string name = Convert.ToString(Console.ReadLine());

// calculate retirement age
int retirementAge = 65 - age;


// print to console
Console.WriteLine($"Working years remaining: {retirementAge}.");

Console.ReadKey();
