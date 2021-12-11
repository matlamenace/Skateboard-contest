using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Skateboard_contest
{
    class Competition
    {
        List<Skateboarder> ranking;
        public Competition() //All the competition is happening in this class
        {
            this.ranking = new List<Skateboarder>();
            Registration(); //to add all the competitors to the list
            Contest(); //Method where user type the tricks that were made by every skateboarder and calculate the score for every competitors 
            Console.ReadKey();
            this.ranking=SortRanking(ranking, 1); //After a score is attributed to each competitor, the ranking list is sorted
            SeeRanking();//the ranked list is printed
            Console.ReadKey();
        }
        public List<Skateboarder> Ranking 
        {
            get { return ranking; }
            set { ranking = value; }
        }
        private void Registration() 
        {
            Console.Clear();
            Skateboarder skateboarder = new Skateboarder();
            ranking.Add(skateboarder);
            Console.WriteLine("If you want to continue, type enter key, if you are done, type escape key");
            ConsoleKeyInfo UserKey = Console.ReadKey();
            if (UserKey.Key == ConsoleKey.Enter) { Registration(); }
            else { Console.WriteLine("--------------------------------------------------");Thread.Sleep(1500); }
            Console.Clear();
            
            
        }
        private void Contest()
        {
            for(int i=0; i < ranking.Count(); i++) 
            {
                Console.WriteLine($"It's {ranking[i].Fullname}'s turn :");
                ranking[i].Score = Score.ScoreForTheRun();
                Thread.Sleep(1000);
                Console.ReadKey();
            }
        }
        private List<Skateboarder> SortRanking(List<Skateboarder> ranking, int iteration) 
        {
            while (iteration < ranking.Count)
            {
                for (int i = 0; i < ranking.Count - 1; i++)
                {
                    if (ranking[i].Score > ranking[i + 1].Score) 
                    {
                        ranking.Reverse(i, 2);
                    }
                }
                return SortRanking(ranking, iteration+1);
            }
            return ranking;
        }
        private void SeeRanking() 
        {
            for(int i = ranking.Count()-1; i>=0 ; i-- )
            {
                if (i == ranking.Count-3) { Console.Write("Third place : "); }
                if (i == ranking.Count - 2) { Console.Write("Second place : "); }
                if (i == ranking.Count - 1) { Console.Write("The winner is : "); }
                Console.WriteLine(ranking[i].Fullname+" with "+ranking[i].Score+" points");
            }
        }

    }
}
