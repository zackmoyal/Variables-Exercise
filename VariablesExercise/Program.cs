namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            string name = "Zack";
            int age = 29;
            char middleInitial = 'D';
            bool isOver18 = true;
            double currentHouseTemp = 71;
            decimal moneyInWallet = 100.00m;

            //Interpolate these variables in a Console.WriteLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is Over 18: {isOver18}");
            Console.WriteLine($"Current Temp: {currentHouseTemp}");
            Console.WriteLine($"Money In Wallet: {moneyInWallet}");
        }
    }
}
