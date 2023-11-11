Random random = new Random();
bool playAgain = true;
String computerInput;
String userInput;
String Again;
while (playAgain)
{
    int val = random.Next(0, 3);
    Console.WriteLine("Input Rock, Paper Or Sessior ");
    userInput = Convert.ToString(Console.ReadLine());
    userInput = userInput.ToUpper();

    if (val == 0)
    {
        computerInput = "ROCK";
    }
    else if (val == 1)
    {
        computerInput = "PAPER";
    }
    else
    {
        computerInput = "SCISSOR";
    }

    switch (computerInput)
    {
        case "ROCK":
            if (userInput == "ROCK")
            {
                Console.WriteLine("Match Drawn");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            else if (userInput == "PAPER")
            {
                Console.WriteLine("You Win");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            else if (userInput == "SCISSOR")
            {
                Console.WriteLine("You Lose");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            break;
        case "SCISSOR":
            if (userInput == "SCISSOR")
            {
                Console.WriteLine("Match Drawn");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            else if (userInput == "ROCK")
            {
                Console.WriteLine("You Win");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            else if (userInput == "PAPER")
            {
                Console.WriteLine("You Lose");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            break;
        case "PAPER":
            if (userInput == "PAPER")
            {
                Console.WriteLine("Match Drawn");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            else if (userInput == "SCISSOR")
            {
                Console.WriteLine("You Win");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            else if (userInput == "ROCK")
            {
                Console.WriteLine("You Lose");
                Console.WriteLine("Your Input " + userInput);
                Console.WriteLine("Computer Input " + computerInput);
            }
            break;
    }
    Console.WriteLine("Do you Want to Play Again ? input Y/N ");
    Again = Console.ReadLine();
    Again = Again.ToUpper();

    if(Again == "Y")
    {
        playAgain=true;
    }
    else
    {
        playAgain = false;
    }
}

Console.WriteLine("Good Day");

Console.ReadKey();
