using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skateboard_contest
{
    class Skateboarder
    {
        string fullname;
        double score;
        
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public double Score
        {
            get { return score; }
            set { score = value; }
        }
        public Skateboarder() 
        {
            Console.WriteLine("Type the complete name of the skateboarder");
            this.Fullname = Console.ReadLine();
        }
        
    }
}
