using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FootballFormation.Classes
{
    /// <summary>
    /// Перелічення можливих позицій гравців.
    /// </summary>
    public enum PositionType
    {
        GK, //Goalkeeper
        LB, //Left Back
        RB, //Right Back
        CB, //Center Back
        LM, //Left Midfielder
        RM, //Right Midfielder
        CM, //Center Midfielder
        LW, //Left Winger
        RW, //Right Winger
        ST  //Striker
    }

    /// <summary>
    /// Клас, що представляє гравця у футбольній моделі.
    /// Наслідує властивості класу <see cref="Person"/>.
    /// Додає позицію (Position) та ціну (Price) гравця.
    /// </summary>
    public class Player : Person
    {
        private int _age;
        private PositionType _position;
        private int _price;
        public Team Team { get; set; }
        private static List<Player> players = new List<Player>();

        /// <summary>
        /// Отримує або встановлює вік гравця.
        /// Має бути в межах від 16 до 60 років включно.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо вік менше 16 або більше 60 років.
        /// </exception>
        public override int Age
        {
            get { return _age; }
            set
            {
                if (value < 16 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("Player`s age must be between 16 and 60.");
                }
                _age = value;

            }
        }

        /// <summary>
        /// Отримує або встановлює позицію гравця.
        /// Має бути дійсним значенням з перерахування <see cref="PositionType"/>.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо позиція не є дійсним значенням з перерахування PositionType.
        /// </exception>
        public PositionType Position
        {
            get { return _position; }
            set
            {
                if (!Enum.IsDefined(typeof(PositionType), value))
                {
                    throw new ArgumentOutOfRangeException("Invalid position type.");
                }
                _position = value;
            }
        }

        /// <summary>
        /// Отримує або встановлює ціну гравця (у мільйонах доларів США).
        /// Повинна бути невід’ємним цілим числом.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо ціна менше 0.
        /// </exception>
        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                _price = value;
            }
        }

        /// <summary>
        /// Ініціалізує новий екземпляр класу <see cref="Player"/> з указаним ім’ям, віком, зростом та позицією.
        /// </summary>
        /// <param name="name"> ім’я гравця. Не може бути null, порожнім або пробільним рядком.</param>
        /// <param name="age"> вік гравця (від 16 до 60 років).</param>
        /// <param name="height"> зріст у сантиметрах (від 140 до 220).</param>
        /// <param name="position"> позиція гравця (одне з допустимих значень <see cref="PositionType"/>).</param>
        /// <param name="price"> ціна гравця (невід’ємне число).</param>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо ім’я є null, порожнім або складається лише з пробілів.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо вік не в межах від 16 до 60 років,
        /// якщо зріст не в межах від 140 до 220 см,
        /// якщо позиція недійсна або якщо ціна від’ємна.
        /// </exception>
        public Player(string name, int age, int height, PositionType position, int price)
            : base(name, age, height)
        {
            Position = position;
            Price = price;

            players.Add(this);
        }

        /// <summary>
        /// Повертає рядкове представлення гравця, яке включає його позицію та ім’я.
        /// </summary>
        /// <returns> рядок у форматі "Позиція, Ім’я".</returns>
        public override string ToString()
        {
            return $"{Position}, {Name}";
        }

        /// <summary>
        /// Видаляє поточного гравця зі списку гравців, якщо він не закріплений за жодною командою.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Виникає, якщо гравець вже прикріплений до команди (Team не є null).
        /// </exception>
        public void Delete()
        {
            if (Team != null)
            {
                throw new InvalidOperationException("Cannot delete player who is assigned to a team.");
            }
            players.Remove(this);
        }

        /// <summary>
        /// Повертає список усіх створених гравців.
        /// </summary>
        /// <returns> список об'єктів <see cref="Player"/>.</returns>
        public static List<Player> GetAllPlayers()
        {
            return players;
        }
    }
}