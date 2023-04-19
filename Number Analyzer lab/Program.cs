
bool playAgain = true;


while (playAgain == true)
{
    {
        Console.WriteLine("What is Your name?");
        Console.WriteLine(" ");
        string name = Console.ReadLine();

        Console.WriteLine($"Hello {name}.  Enter an integer between 1 and 100.");
        Console.WriteLine(" ");

        int number = 0;
        string input = Console.ReadLine();
        number = int.Parse(input);


        Console.WriteLine($"Ok {name}. You entered {number}.");
        Console.WriteLine(" ");


        if (number % 2 == 1 && number < 60)
        {
            Console.WriteLine($"{name}, You entered {number}, and it is Odd and less than 60.");
        }
        else if (number % 2 == 0 && number < 25)
        {
            Console.WriteLine($"{name}, {number} is Even and less than 25.");
        }
        else if (number % 2 == 0 && 26 <= number && number <= 60)
        {
            Console.WriteLine($"{name}, {number} is Even and between 26 and 60.");
        }
        else if (number % 2 == 0 && number > 60)
        {
            Console.WriteLine($"{name}, {number} is Even and greater than 60.");
        }
        else if (number % 2 == 1 && number > 60)
        {
            Console.WriteLine($"{name}, {number} is odd and greater than 60.");
        }

        Console.WriteLine("Would you like to play again? y/n");
        Console.WriteLine(" ");

        input = Console.ReadLine();
        if (input == "n")
        {
            playAgain = false;
        }
    }
}