

Console.Write("What is your name: ");
string name = Console.ReadLine();
string greeting = $"Hello {name}";
Console.WriteLine(greeting);

int nameKescha = 3;
Console.Write("How old are you: ");
string ageAsString = Console.ReadLine();
Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
int sum = age - nameKescha;



Console.WriteLine($"You are older than KESCHA: {sum > 0}");































