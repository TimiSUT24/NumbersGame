// Tim Petersen (SUT24). 

namespace NumbersGame
{

    public class Program
    {   
        static bool Checkguess(int user, int number, int guessLeft)
        {
            if (user == number)
            {
                Console.WriteLine("Whohoo du gissade rätt!!! ");
                return true;
            }
            else
            {
                Console.WriteLine("Fel");
                Console.WriteLine();
            }

            if(user < number)
            {
                Console.WriteLine("Gissa Högre");
            }
            else if(user > number)
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
        }

    }
}
