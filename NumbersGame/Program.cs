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
        }

        static void Main(string[] args)
        {

        }

    }
}
