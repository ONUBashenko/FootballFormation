using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Football_Formation
{
    public class Coach : Person
    {
        //public List<Formation> Formations {get; set;} later
        private int _experience;

        public int Experience
        {
            get {return _experience;}
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Experience cannot be negative.");
                }
                _experience = value;
            }
        }

        public Coach(string name, int age, int height, int experience)
            : base(name, age, height)
        {
            Experience = experience;
           // Formations = new List<Formation>();
        }
    }
}
