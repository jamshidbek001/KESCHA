

Console.Write("What is your name: ");
string name = Console.ReadLine();
string greeting = $"Hello {name}";
Console.WriteLine(greeting);

Console.Write("How old are you: ");
string ageAsString = Console.ReadLine();
Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
Console.WriteLine("Successfully converted your age");






























