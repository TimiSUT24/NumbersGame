// Tim Petersen (SUT24). 

namespace NumbersGame
{

    public class Program
    {
        // Check the guesses from the user in a method.
        static bool Checkguess(int user, int number, int guessLeft)
        {
            // User wins if guesses the right number.
            if (user == number)
            {
                Console.WriteLine("Whohoo du gissade rätt!!! ");
                return true;
            }
            else
            {   // If wrong prints this.
                Console.WriteLine("Fel");
                Console.WriteLine();
            }

            // If guess is low it will print "Guess higher".
            if (user < number)
            {
                Console.WriteLine("Gissa högre");
            }
            // Here it wil be "Guess Lower".
            else if (user > number)
            {
                Console.WriteLine("Gissa lägre");
            }
            return false;
        }

        static void Main(string[] args)
        {
            int user;
            bool run = true;
            int number = 0;
            int guessLeft;

            while (run)
            {   
                // Greets user and ask for game difficulty.
                Console.WriteLine("Välkommen till gissa numret!");
                Console.WriteLine("Välj svårighetsgrad |1| |2| |3|");
                int difficulty = Convert.ToInt32(Console.ReadLine());
                Random num = new Random();

                // Switch statement if user chooses number 1 it will randomize a number between 1-10
                switch (difficulty)
                {
                    case 1:
                        number = num.Next(1, 11);
                        break;
                    case 2:
                        number = num.Next(1, 21);
                        break;
                    case 3:
                        number = num.Next(1, 31);
                        break;

                    default:
                        Console.WriteLine("Kan bara Välja från 1-3!!!");
                        return;
                }

                guessLeft = 5;
                Console.WriteLine("Dags att köra!!!\nJag tänker på ett nummer kan du gissa vilket? Du får 5 försök.");

                //  Loops while guessLeft is bigger than 0 or user wins.
                while (guessLeft > 0)
                {
                    Console.WriteLine("Försök kvar: " + guessLeft);
                    guessLeft--;
                    Console.WriteLine("Gissa:");
                    // Saves the user input.
                    user = Convert.ToInt32(Console.ReadLine());
                    // Calls the Checkguess method. 
                    bool userwon = Checkguess(user, number, guessLeft);

                    if (userwon)
                    {
                        break;
                    }

                    if (guessLeft == 0)
                    {
                        Console.WriteLine("Du förlora!!");
                        break;
                    }
                }

                // Asks the user to play again. 
                Console.WriteLine("Vill du köra mer? Tryck y/n ");
                ConsoleKeyInfo runMore = Console.ReadKey();
                if (runMore.Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }

    }
}
