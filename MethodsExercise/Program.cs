namespace MethodsExercise
{
    public class Program
    {
        

        static void Main(string[] args)
        {

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

            Console.WriteLine("Now let me show you what I can do. First, give me a number.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Now give me another number, and I'll add them together.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            
            Console.WriteLine($"Added together, those numbers = {sum}. How's that? Now let me do some multiplication for you. Give me a new number.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ok. Now give me one more, please.");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);

            Console.WriteLine($"Thank you. Multiplying those numbers gives you {product}. Are you impressed?");

        }
        public static int Sum(int num1, int num2)
        {
            int sumAnswer = num1 + num2;
            return sumAnswer;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }



    }
}
