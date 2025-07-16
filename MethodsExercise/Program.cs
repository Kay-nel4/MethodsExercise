namespace MethodsExercise2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What I am going to create with this fun little story?");
        SillyQuestionnaire();
        Console.WriteLine("Let's Move on to some Math! Woo Hoo!");
        Console.WriteLine(Add(4, 4));
        Console.WriteLine(Subtract(4, 4));
        Console.WriteLine(Divide(4, 4));
        Console.WriteLine(Multiply(4, 4));
        Console.WriteLine("Ok that was fun... but just Practice, Let's Math for real now.");
        Console.WriteLine(AddTwoNumbers());
        Console.WriteLine(MultiplyTwoNumbers());
        Console.WriteLine("Thanks for playing along, I will still be using this to work more on params and more fun!\nThis is just the beginning!");
        
    }

    public static void SillyQuestionnaire()
    {
        Console.WriteLine("Hello Player, What is a good name for you?");
        string name = Console.ReadLine();
        Console.WriteLine("Let's hear your favorite animal?(plural)");
        string animal = Console.ReadLine();
        Console.WriteLine("Adoption is important... So how many friends will you adopt?");
        int friends = int.Parse(Console.ReadLine());
        Console.WriteLine("That is a lot of new friends, which means a lot of treats! What kind will you feed them?");
        string kind = Console.ReadLine();
        Console.WriteLine("That sounds great... and of course don't forget their favorite food!\nWhat food will it be?");
        string food = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Hi {name}, thanks for dropping by today, we are so happy to have you adopt {friends} {animal}.\n Surely they will love their new home, it will be filled with so much love, fun, {kind}, and {food}! Oh and don't forget the fresh water!\nAgain thanks for choosing adoption and let us know if there are any questions!");

    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Divide(int num1, int num2)
    {
        return num1 / num2;
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    
    public static int AddTwoNumbers()
    {
        Console.WriteLine("Hello I will need two different numbers!");
        Console.WriteLine("First Number Please:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Thanks\nSecond Number Please:");
        int secondNumber = int.Parse(Console.ReadLine());
        int result = firstNumber + secondNumber;
        return result;
    }

    public static int MultiplyTwoNumbers()
    {
        Console.WriteLine("Hi just a bit more practice... I will need two different numbers again!");
        Console.WriteLine("First Number Please:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Second Number Please:");
        int secondNumber = int.Parse(Console.ReadLine());
        int result = firstNumber * secondNumber;
        return result;
    }
    //TryParse
    
    
    

}
