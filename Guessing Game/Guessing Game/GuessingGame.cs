
class GuessingGame
{
    static void Main(string[] args)
    {

        Random random = new Random();
        string response;
        bool replay = true;
        int max = 50;
        int min = 0;
        int guess;
        int number;


        while (replay)
        {
            guess = 0;
            response = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Gues a number between " + min + " and " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your guess " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + " My number is smaller.");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " My number is bigger..");
                }
            }

            Console.WriteLine("Bullseye!");
            Console.WriteLine("Play again (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                replay = true;
            }
            else
            {
                replay = false;
            }
        }
    }
}
