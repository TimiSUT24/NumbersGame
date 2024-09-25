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

            while (run)
            {
                Console.WriteLine("Välkommen till gissa numret!");
                Console.WriteLine("Välj svårighetsgrad |1| |2| |3|");
                int difficulty = Convert.ToInt32(Console.ReadLine());
                Random num = new Random();

                switch (difficulty)
                {
                    case 1:
                        number = num.Next();
                        break;
                    case 2:
                        number = num.Next();
                        break;
                    case 3:
                        number = num.Next();
                        break;

                    default:
                        Console.WriteLine("Kan bara Välja från 1-3!!!");
                        return; 
                }

                guessLeft = 5;
                Console.WriteLine("Dags att köra!!!\n Jag tänker på ett nummer kan du gissa vilket? Du får 5 försök.");

                while (guessLeft > 0)
                {
                    Console.WriteLine("Försök kvar:" + guessLeft);
                    guessLeft--;
                    Console.WriteLine("Gissa:");

                    user = Convert.ToInt32(Console.ReadLine());


                }
            }
        }

    }
}
