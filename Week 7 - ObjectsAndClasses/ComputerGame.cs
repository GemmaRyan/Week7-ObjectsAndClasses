using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7___ObjectsAndClasses
{
    internal class ComputerGame : Game
    {
        private string _PEGIrating;

        public string PEGIrating
        {
            get;
            set;
        }

        public ComputerGame(string name, decimal price, DateTime releaseDate , string rating ) : base(name , price, releaseDate)
        {
            PEGIrating = rating;
        }

        public decimal GetDiscountPrice() 
        {
            return Price * 9;
        }

        public override void UpdatePrice(decimal percentIncrease)
        {
            Price *= (1 + percentIncrease);
            Console.WriteLine("Overriding the Price!");
        }
        public override string ToString() 
        {
            return $"{base.ToString()} PEGI {PEGIrating}";
        }
    }
}
