using KESCHA.Enums;

namespace KESCHA.Classes
{
    public class Pet : Animal
    {
        public PetType Type { get; set; }
        public Pet(string name, int age)
            : base(name, age)
        {

        }

        public override void Greet(string userName)
        {
            Console.WriteLine($"Meoww, {userName}");
        }

        public override void Greet2(string userName)
        {
            Console.WriteLine();
        }
    }
}