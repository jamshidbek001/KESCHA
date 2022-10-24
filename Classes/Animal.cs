namespace KESCHA.Classes
{
    public abstract class Animal : IAnimal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
            CreatedDate = DateTimeOffset.Now;
        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Animal(
            int userAge,
            int animalAge,
            string name)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
            CreatedDate = DateTimeOffset.Now;
        }

        public abstract void Greet2(string userName);

        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference between your and {Name} age is {AgeDifference}");
        }

        public void CompareAges(int userAge)
        {
            if (userAge < Age)
            {
                Console.WriteLine("You are younger ");
            }
            else if (userAge == Age)
            {
                Console.WriteLine("You are equal");
            }
            else
            {
                Console.WriteLine("You are older");
            }
        }

        public void TellAboutFriend(string userName)
        {
            Console.WriteLine("Let me tell about my friends");
            string[] friendsName = { "Vasya", "Kasee", "Vale" };
            int[] friendsAge = { 7, 3, 9 };
            string[] adress = { "Andijan", "Fargona", "Toshkent" };

            for (int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} year old and she is from {adress[i]}");
            }
        }

        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }

        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }
        public virtual void Greet(string userName)
        {
            if (userName == "")
            {
                userName = "Unknown Person";
            }
            Console.WriteLine($"Hello {userName}");
        }


        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }

    // Shape boshlandi 
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shakl chizildi");
        }
    }
    public class Circle : Shape
    {
        public float _radius;
        public Circle(float radius)
        {
            this._radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Radiusi {_radius} ga teng bo'lgan aylana chizildi ");
        }
    }

    public class Triangle : Shape
    {
        public float _a;
        public float _b;
        public float _c;
        public Triangle(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public override void Draw()
        {
            Console.WriteLine($"Tomonlari {_a} {_b} {_c} ga teng bo'lgan uchburchak chizildi ");
        }
    }

    public class Rectangle : Shape
    {
        public float _width;
        public float _height;

        public Rectangle(float width, float height)
        {
            _width = width;
            _height = height;
        }
        public override void Draw()
        {
            Console.WriteLine($"Tomonlari {_width} va {_height} ga teng bo'lgan to'rtburchak chizildi ");
        }
    }
    // Shape tugadi  
}