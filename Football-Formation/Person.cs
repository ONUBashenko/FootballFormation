using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Formation
{
    /// <summary>
    /// Represents a abstract base class for a person in the football formation system.
    /// Contains basic properties such as name, age, and height.
    /// </summary>
    public abstract class Person
    {
        private string _name;
        private int _age;
        private int _height;

        /// <summary>
        /// Gets or sets the person's name.
        /// Cannot be null, empty, or whitespace.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when the provided name is null, empty, or consists only of white-space characters.
        /// </exception>
        public string Name
        {
            get {return _name;}
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Gets or sets the person's age.
        /// Must be between 15 and 100 inclusive.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the age is less than 15 or greater than 100.
        /// </exception>
        public int Age
        {
            get {return _age;}
            set 
            {
                if (value < 15 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 15 and 100.");
                }
                _age = value;

            }
        }

        /// <summary>
        /// Gets or sets the person's height in centimeters.
        /// Must be between 140 and 250 inclusive.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the height is less than 140 or greater than 250.
        /// </exception>
        public int Height
        {
            get {return _height;}
            set 
            {
                if (value < 140 || value > 250)
                {
                    throw new ArgumentOutOfRangeException("Height must be between 140 and 250 cm.");
                }
                _height = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with the specified name, age, and height.
        /// </summary>
        /// <param name="name">The person's name. Cannot be null or whitespace.</param>
        /// <param name="age">The person's age (between 15 and 100).</param>
        /// <param name="height">The person's height in centimeters (between 140 and 250).</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the name is null, empty, or whitespace.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the age or height is outside the allowed range.
        /// </exception
        public Person(string name, int age, int height)
        {
            /* if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            _name = name; */

            Name = name;
            Age = age;
            Height = height;
        }
    }
}
