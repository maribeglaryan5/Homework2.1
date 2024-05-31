namespace Project1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello. What's your name?");
        var userInput = Console.ReadLine();
        Console.WriteLine($"Your name is {userInput}.");
        Console.WriteLine("What's your surname?");
        var surname = Console.ReadLine();
        Console.WriteLine("$Your surname is {surname}.");
        Console.WriteLine("How old are you?");
        var age = Console.ReadLine();
        Console.WriteLine($"You are {age}.");
        Console.WriteLine("What's your profession?");
        var profession = Console.ReadLine();
        Console.WriteLine($"You are {profession}.");

    }
}
