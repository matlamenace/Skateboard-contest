using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Skateboard_contest
{
    class Score //This class has only one method, wich allow a user to set a trick for a skateboarder and calculate and return the amout of point the skateboarder got 
    {
        //These are the dictionaries used to calculate the final scores
        public static Dictionary<string, double> stancescore = new Dictionary<string, double>() { { "Normal", 1 }, { "Switch", 2 }, { "Fakie", 1.2 }, { "Nollie", 1.6 } };
        public static Dictionary<string, int> trickscore = new Dictionary<string, int>() { { "Kickflip", 10 }, { "360 flip", 15 }, { "Impossible flip", 20 }, { "Crooked grind", 15 }, { "Fifty-fifty", 10 } };
        public static Dictionary<string, double> areascore = new Dictionary<string, double>() { { "On a ledge", 1.2 }, { "On a slide bar", 1.4 }, { "Over the stairs", 1.5 }, { "On the floor", 1 },{"In a curve",1.4 } };
        public static double ScoreForTheRun() 
        {
            Console.WriteLine("What trick did the rider do ? Choose between 'Kickflip','360 flip','Impossible flip','Crooked grind', 'Fifty-fifty'");
            string trick = Console.ReadLine();
            Console.Clear();
            if (trickscore.ContainsKey(trick) == false) 
            {
                Console.WriteLine("The trick you entered doesn't exist, please try again, type to continue");
                Console.ReadKey();
                Console.Clear();
                return ScoreForTheRun();
            }
            Console.WriteLine("What stance did the rider have ? Choose between 'Normal','Switch ','Fakie','Nollie'");
            string stance = Console.ReadLine();
            Console.Clear();
            if (stancescore.ContainsKey(stance) == false)
            {
                Console.WriteLine("The stance you entered doesn't exist, please try again, type to continue");
                Console.ReadKey();
                Console.Clear();
                return ScoreForTheRun();
            }
            Console.WriteLine("Where did the skater do his trick ? Choose between 'On a ledge','On a slide bar','Over the stairs','On the floor'");
            string area = Console.ReadLine();
            Console.Clear();
            if (areascore.ContainsKey(area) == false)
            {
                Console.WriteLine("The aera you entered doesn't exist, please try again, type to continue");
                Console.ReadKey();
                Console.Clear();
                return ScoreForTheRun();
            }
            double finalscore = stancescore[stance] * trickscore[trick] * areascore[area];
            Console.WriteLine($"The competitor received {finalscore}");
            Thread.Sleep(1500);
            Console.WriteLine("End of");
            return finalscore;

        }
    }
}
