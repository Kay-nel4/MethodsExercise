

using System.ComponentModel.Design;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a story that prompts the user for different add ins throughout.
            //I would like to get a really good grasp on handling basic method creation.

            Console.WriteLine("What kind of story will I create and how will I use these methods?");
            string name = GetName();
            string animal = GetAnimalType();
            int amount = AskHowMany();
            string treat = TreatType();
            int bags = HowManyBagsOfTreats();
            Console.WriteLine($"Hello {name}... I like {animal} too!\n You should give {amount} of them a home! That is a lot of food and treats!\nI think they really love {treat}, {bags} bags is a perfect amount to start with.\nAre there any other animals on your List?");
            string animal2 = GetAnimalType();
            double number = HowMuch();
            Console.WriteLine($"{animal2} are super fun too! Thanks a {number}% for participating in such a random questionnaire!");
            Console.WriteLine("Is this too many methods? I want to do my best to keep this clean?");
        }
        //Create a method to get a name that can be called and interpolated in the story.
        public static string GetName()
        {
            Console.WriteLine("Hello, Player! What's a good name for you?");
            return Console.ReadLine();
        }
        
        public static string GetAnimalType()
        {
            Console.WriteLine("What is your favorite animal?");
            return Console.ReadLine();
        }
        //Create a method to get a number (int)
        public static int AskHowMany()
        {
            Console.WriteLine("How many of this animal will you adopt?");
            return int.Parse(Console.ReadLine());
        }

        public static string TreatType()
        {
            Console.WriteLine("What is your favorite treat?");
            return Console.ReadLine();
        }

        public static int HowManyBagsOfTreats()
        {
           Console.WriteLine("How many bags of treats?");
           return int.Parse(Console.ReadLine());
           
        }
        //Choose a method to reuse before the final question.
        public static double HowMuch()
        {
            Console.WriteLine("Final Question: Pick a number between 50 and 150!");
            return double.Parse(Console.ReadLine());
        }
        
    }
}
