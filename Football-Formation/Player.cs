using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Football_Formation
{
    public class Player : Person
    {
        // public Position Position {get; set;}
        private int _price;

        public int Price
        {
            get {return _price;}
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                _price = value;
            }
        }
        public Player(string name, int age, int height, /*Position position */ int price)
            : base(name, age, height)
        {
           // Position = position;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Height: {Height}, Position:, Price: {Price}$."; // {Position.MainPosition}
        }
    }
}
