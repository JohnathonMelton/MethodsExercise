namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite outdoor sport?");
            string favoriteSport = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string Animal = Console.ReadLine();

            Console.WriteLine("Do you like rivers, streams, or the ocean?");
            string Water = Console.ReadLine();

            Console.WriteLine($"{userName} was a quiet individual with a joy for the outdoors.");
            Console.WriteLine($"They would spend hours by the {Water} relaxing and enjoying the peace that came with the landscape.");
            Console.WriteLine($"If they couldn't be found relaxing there, they could be found watching their favorite {Animal} show on T.V.");
            Console.WriteLine($"When the sense of adventure and fun would take them, They would indulge in {favoriteSport} with friends.");

            Console.WriteLine("Give me a number.");
            int num1 = int.Parse( Console.ReadLine() );

            Console.WriteLine("Give me another number.");
            int num2 = int.Parse( Console.ReadLine() );

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sume is {sum}");

            Console.WriteLine("Give me a new number.");
            int x = int.Parse( Console.ReadLine() );

            Console.WriteLine("Give me a second number.");
            int y = int.Parse( Console.ReadLine() ) ;

            int multiply = Multiply(x, y);
            Console.WriteLine($"The product is {multiply}");

            Console.WriteLine("Give me a number.");
            int a = int.Parse(Console.ReadLine() );

            Console.WriteLine("Give me another number.");
            int b = int.Parse (Console.ReadLine() ) ;

            int subtract = Subtract(a, b);
            Console.WriteLine($"The difference is {subtract}");

            Console.WriteLine("Give me a number to divide.");
            int c = int.Parse (Console.ReadLine()) ;

            Console.WriteLine("Give me another number.");
            int d = int.Parse(Console.ReadLine());

            int divide = Divide(c, d);
            Console.WriteLine($"The answer is {divide}");

            Console.WriteLine("Give me a number.");
            int e = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("Give me a final number.");
            int f = int.Parse(Console.ReadLine());

            int modulus = Modulus(e, f);
            Console.WriteLine($"The answer is {modulus}");




        }

        public static int Sum(params int[] list)
        {
            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Divide(int c, int d)
        {
            return c / d;
        }
        public static int Modulus(int e, int f)
        {
            return e % f;
        }

    }
}
