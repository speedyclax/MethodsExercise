namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
        //----------------------Exercise 1---------------------------------------
        //Name: 
        //Favorite Color: 
        //Favorite Animal: 
        //Favorite Band: 

            Console.WriteLine("Thank you for signing up for this dating service. First question: What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}. Such a lovely name. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color}? That's my favorite color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal}? Really? What are the odds? That's also my favorite animal. Weird. So what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Get out! I love {band}! We have so much in common. Anyways, here is your basic profile:");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Name:            {userName}");
            Console.WriteLine($"Favorite color:  {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band:   {band}");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("This is awkward, but I really like you. Can I get your number? You can just type it in.");


        //----------------------Exercise 2---------------------------------------

        }



    }
}
