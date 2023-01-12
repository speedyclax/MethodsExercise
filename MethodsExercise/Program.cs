namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}. Where are you from?");
            var location = Console.ReadLine();
            Console.WriteLine($"{location}? Interesting. What's the temperature today?");
            var temp = Console.ReadLine();
            //Wanting to insert if/then statement with a "sounds nice" or "sounds cold" answer dependent on the answer
            Console.WriteLine($"{temp} sounds nice. Enjoy that weather and have a good day!");


        }



    }
}
