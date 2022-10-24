

using KESCHA.Classes;

namespace KESCHA
{
    class Program
    {





        // public enum ranglar
        // {
        //     qizil,
        //     sariq,
        //     yashil = 4,
        //     kok,
        //     qora
        // }
        // enum mashinalar
        // {
        //     Nexia3 = 87000000,
        //     Lacetti = 100000000,
        //     Gentra = 120000000,
        //     Spark = 80000000,
        //     Damas = 75000000,
        //     Malibu = 275000000,
        //     Kaptiva = 260000000,

        static void Main(string[] args)
        {
            // Shape boshlandi

            Circle circle = new Circle(5);
            circle.Draw();
            Triangle triangle = new Triangle(3, 4, 5);
            triangle.Draw();
            Rectangle rectangle = new Rectangle(4, 5);
            rectangle.Draw();




            // Shape tugadi 

            // double[] arr = new double[]
            // {
            //     2, 3.3, 5, 5, 89.0, 112.2, 98, 77
            // };
            // Console.WriteLine(Max(2, 3.3));
            // Console.WriteLine(Max(4, 5, 48));
            // Console.WriteLine(Max(arr));




            // string[] rang = Enum.GetNames(typeof(ranglar));
            // foreach (var r in rang)
            // {
            //     Console.WriteLine(r);
            // }
            // int[] values = (int[])Enum.GetValues(typeof(ranglar));
            // foreach (var m in values)
            // {
            //     Console.WriteLine(m);
            // }

            // Console.Write(mashinalar.Malibu + " ning narxi:");
            // int narxi = (int)mashinalar.Malibu;
            // Console.WriteLine(narxi + " so'm ");

            try
            {
                Bird kescha = new Bird(name: "Kescha", age: 3);
                Pet kase = new Pet(name: "Kase", age: 4);

                kescha.Type = Enums.BirdTYpe.Falcon;
                kase.Type = Enums.PetType.Cat;

                Console.WriteLine("Kescha was created" + kescha.CreatedDate);
                Console.WriteLine("Kaase was created" + kase.CreatedDate);

                Console.WriteLine(kescha.Type);
                Console.WriteLine((int)kase.Type);

                Console.Write("What is your name: ");
                string userName = Console.ReadLine();

                kescha.Greet(userName);
                kase.Greet(userName);

                Console.Write("How old are you: ");
                string ageAsString = Console.ReadLine();
                Console.WriteLine("Converting...");
                int userAge = Convert.ToInt32(ageAsString);


                kescha.CalculateAgeDifferenceWithNoReturn(userAge);
                kescha.PrintAgeDifference();
                kescha.CompareAges(userAge);
                kescha.TellAboutFriend(userName);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"Error was occurred. Message: {formatException.Message}");
            }

            catch (Exception exception)
            {
                Console.WriteLine("Error was occurred. Type was not known.");
            }
            Console.WriteLine("Program ended.");

        }
        // static double Max(double number1, double number2)
        // {
        //     return (number1 > number2) ? number1 : number2;
        // }

        // static double Max(double number1, double number2, double number3)
        // {
        //     if (number1 > number2 && number1 > number3) return number1;
        //     else if (number2 > number1 && number2 > number3) return number2;
        //     else if (number3 > number1 && number3 > number2) return number3;
        //     else return -1;
        // }

        // static double Max(double[] arr)
        // {
        //     if (arr != null)
        //     {
        //         double max = arr[0];
        //         for (int i = 1; i < arr.Length; i++)
        //         {
        //             if (arr[i] > max) max = arr[i];
        //         }
        //         return max;
        //     }
        //     else return -1;
        // }

    }
}






// Console.WriteLine("Let me tell about my friends");
// string[] friendsName = { "Vasya", "Kasee", "Vale" };
// int[] friendsAge = { 7, 3, 9 };
// string[] adress = { "Andijan", "Fargona", "Toshkent" };
// Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} year old and she is from {adress[0]}");
// Console.WriteLine($"{friendsName[1]} is {friendsAge[1]} year old and she is from {adress[1]}");
// Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} year old and she is from {adress[2]}");

// for (int i = 0; i < friendsName.Length; i++)
// {
//     Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} year old and she is from {adress[i]}");
// }

//    Car 


// Console.WriteLine("What brand do you want to buy: ");
// string brandCar = Console.ReadLine();


// Console.WriteLine("How much money do you have: ");
// int money = Convert.ToInt32(Console.ReadLine());
// int purchasePayment = 4000;
// int paymentDifference = purchasePayment - money;

// Console.WriteLine($"The difference between your money and car's payment is {paymentDifference}.You can't afford to buy it.");

// Console.Write("Type your first number: ");
// int fNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Type your second number: ");
// int sNumber = Convert.ToInt32(Console.ReadLine());

// string message =
//     (fNumber >= 0)
//         ? "first numebr is not  positive"
//         : "first number is not negative";

// Console.WriteLine(message);




// if (fNumber >= sNumber)
// {
//     Console.WriteLine("First number is bigger than second");
// }
// else
// {
//     Console.WriteLine("First number is smaller than second");
// }





// Console.Write("Type your number: ");
// int fNumber = Convert.ToInt32(Console.ReadLine());

// int keschasAge = 11;

// int ageDifference = fNumber - keschasAge;

// if (fNumber >= 18 || keschasAge >= 18)
// {
//     Console.WriteLine("You can enter room");
// }
// else
// {
//     Console.WriteLine("You have to grow up");
// }










// Console.WriteLine("What is your name: ");
// string name = Console.ReadLine();
// Console.WriteLine($"Nice to meet you {name}");
// Console.WriteLine("What is your age: ");
// int keschaAge = 32;

// int yourAge = Convert.ToInt32(Console.ReadLine());

// if (keschaAge > yourAge)
// {
//     Console.WriteLine("You are younger");
// }
// else if (keschaAge == yourAge)
// {
//     Console.WriteLine("Heyy, we are the same age");
// }
// else
// {
//     Console.WriteLine("You are older");
// }

// Console.WriteLine($"My age is {keschaAge}");



// foreach (string naMe in friendsName)
// {
//     Console.WriteLine(naMe);
// }



// int namber = 10;

// for (int num = 1; num < namber; num++)
// {
//     if (num % 2 == 0)
//         Console.WriteLine(num);
// }










