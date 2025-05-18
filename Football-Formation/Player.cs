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
        public enum PositionType
        {
            Goalkeeper,
            Defender,
            Midfielder,
            Forward
        }
        public struct AvailablePositions
        {
            public PositionType MainPosition {get; set;}
            public List<PositionType> SecondaryPositions {get; set;}
        }
        private AvailablePositions _availablePositions;
        private int _price;

        public PositionType MainPosition
        {
            get {return _availablePositions.MainPosition;}
            set
            {
                if (!Enum.IsDefined(typeof(PositionType), value))
                {
                    throw new ArgumentOutOfRangeException("Invalid position.");
                }
                _availablePositions.MainPosition = value;
            }
        }
        public List<PositionType> SecondaryPositions
        {
            get {return _availablePositions.SecondaryPositions;}
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Secondary positions cannot be null or empty.");
                }
                if (value.Contains(_availablePositions.MainPosition))
                {
                    throw new ArgumentException("Secondary positions cannot contain the main position.");
                }
                _availablePositions.SecondaryPositions = value;
            }
        }
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
        public Player(string name, int age, int height, PositionType position, int price)
            : base(name, age, height)
        {
            MainPosition = position;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Height: {Height}, Position: {MainPosition}, Price: {Price}$."; // {Position.MainPosition}
        }
    }
}
