using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7___ObjectsAndClasses
{
    internal abstract class Game 
    {
        private  readonly string _name;
        private decimal _price;
        private DateTime _releaseDate;



        public string Name 
        {
            get { return _name; }
            
        }
        protected decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public DateTime ReleaseDate 
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }




        public Game(string name, decimal price, DateTime releaseDate) 
        { 
            _name = name;
            Price = price;
            ReleaseDate = releaseDate;
        }
        public Game(string name, decimal price) : this (name, price, DateTime.Now)
        { 
        }
        public Game() :this ("" , 0)
        { 
        }
        


        public override string ToString()
        {
            return $"{Name} , {Price:C} , {ReleaseDate.ToShortDateString() }";
        }

        public abstract void UpdatePrice(decimal percentIncrease);
        //{
        //    Price *= (1 + percentIncrease);
        //}




    }
}
