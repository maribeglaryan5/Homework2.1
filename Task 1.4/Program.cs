namespace Task_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. How old are you?");
            var userInput = Console.ReadLine();
            int age = Convert.ToInt32(userInput);
            Console.Write($"Your year of birth is {2024 - age}.");
        }
    }
}
