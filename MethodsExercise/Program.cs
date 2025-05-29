namespace MethodsExercise
{
    public class Program
    {
        public static string GetUserName()
        {
            Console.WriteLine("Please enter your name.");
                
            string name = Console.ReadLine();
                
            return name;
        }
         public static string GetFavoriteColor()
        {
            Console.WriteLine("Please enter your favorite color.");
            
            string color = Console.ReadLine();

            return color;
        }

        public static string GetFavoriteAnimal()
        {
            Console.WriteLine("Please enter your favorite animal.");
            
            string animal = Console.ReadLine();
            
            return animal;
        }

        public static string GetFavoriteBand()
        {
            Console.WriteLine("Please enter your favorite band.");
            
            string band = Console.ReadLine();
            
            return band;
        }

        public static void AddTwoNumbers()
        {
            Console.WriteLine("For A + B = C");
            Console.WriteLine("A = _ ");

            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("B = _ ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine($"C = {numB + numA}");
        }

        public static void MultiplyTwoNumbers()
        {
            Console.WriteLine("For A * B = C");
            Console.WriteLine("A = _ ");
        
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("B = _ ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine($"C = {numB * numA}");
        }

        public static void SubtractTwoNumbers()
        {
            Console.WriteLine("For A - B = C");
            Console.WriteLine("A = _ ");
        
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("B = _ ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine($"C = {numB - numA}");
        }

        public static void DivideTwoNumbers()
        {
            Console.WriteLine("For A / B = C");
            Console.WriteLine("A = _ ");

            double numA = double.Parse(Console.ReadLine());
            Console.WriteLine("B = _ ");
            double numB = double.Parse(Console.ReadLine());
            Console.WriteLine($"C = {numB / numA}");
        }

        static void Main(string[] args)
        {
            string name = GetUserName();
            string color = GetFavoriteColor();
            string animal = GetFavoriteAnimal();
            string band = GetFavoriteBand();
            Console.WriteLine($"The {color} {animal} sat on {name}'s head at the {band} concert. It made a good hat.");
            Console.WriteLine("Calculator Activated");
            AddTwoNumbers();
            MultiplyTwoNumbers();
            SubtractTwoNumbers();
            DivideTwoNumbers();
           Console.WriteLine("Calculator Deactivated. Have a nice day.");
        }
    }
}
