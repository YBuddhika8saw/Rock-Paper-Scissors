internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        String Input;
        while(playAgain)
        {   
            int val =random.Next(0,3);
            Console.WriteLine("Input Rock, Paper Or Sessior ");
            Input = Convert.ToString(Console.ReadLine());

        }

              Console.ReadKey();
    }
}