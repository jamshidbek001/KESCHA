using KESCHA.Enums;

namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public BirdTYpe Type { get; set; }
        public Bird(string name, int age)
            : base(name, age)
        {

        }
        public override void Greet(string userName)
        {
            Console.WriteLine($"Hello, {userName}");
        }

        public override void Greet2(string userName)
        {
            Console.WriteLine("Hello Abstract");
        }
    }
}