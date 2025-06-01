using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormation
{
    /// <summary>
    /// Базовий абстрактний клас для представлення людини у футбольній моделі.
    /// Містить властивості: ім'я (Name), вік (Age), зріст (Height).
    /// </summary>
    public abstract class Person
    {
        private string _name;
        public abstract int Age {get; set;}
        private int _height;

        /// <summary>
        /// Отримує або встановлює ім’я.
        /// Не може бути null, порожнім або складатися лише з пробілів.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо ім’я є null, порожнім або містить лише пробіли.
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
        /// Отримує або встановлює зріст людини в сантиметрах.
        /// Має бути в межах від 140 до 220 см включно.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо зріст менше 140 або більше 220 см.
        /// </exception>
        public int Height
        {
            get {return _height;}
            set 
            {
                if (value < 140 || value > 220)
                {
                    throw new ArgumentOutOfRangeException("Height must be between 140 and 220 cm.");
                }
                _height = value;
            }
        }

        /// <summary>
        /// Ініціалізує новий екземпляр класу <see cref="Person"/> з указаними ім’ям, віком та зростом.
        /// </summary>
        /// <param name="name"> ім’я людини. Не може бути null, порожнім або пробільним рядком.</param>
        /// <param name="age"> вік людини. Повинен бути реалізований у похідному класі.</param>
        /// <param name="height"> зріст у сантиметрах (від 140 до 220).</param>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо ім’я є null, порожнім або складається лише з пробілів.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо зріст не в межах від 140 до 220 см.
        /// </exception>
        public Person(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
        }
    }
}
