using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormation.Classes
{
    /// <summary>
    /// Клас для представлення тренера у футбольній моделі.
    /// Наслідує властивості класу <see cref="Person"/>.
    /// Додає тактичні схеми (Formations) та досвід (Experience) тренера.
    /// </summary>
    public class Coach : Person
    {
        private int _age;
        private List<FormationType> _formations = new List<FormationType>();
        private int _experience;
        public Team? Team { get; set; }
        private static List<Coach> coaches = new List<Coach>();

        /// <summary>
        /// Отримує або встановлює вік тренера.
        /// Має бути в межах від 28 до 80 років включно.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо вік менше 28 або більше 80 років.
        /// </exception>
        public override int Age
        {
            get { return _age; }
            set
            {
                if (value < 28 || value > 80)
                {
                    throw new ArgumentOutOfRangeException("Coach age must be between 28 and 80.");
                }
                _age = value;

            }
        }

        /// <summary>
        /// Отримує або встановлює перелік формацій (тактичних схем), які використовує тренер.
        /// Не може бути null.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Виникає, якщо значення є null.
        /// </exception>
        public List<FormationType> Formations
        {
            get { return _formations; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Formations cannot be null");
                }
                if (value.Count == 0)
                {
                    throw new ArgumentException("Formations cannot be empty.");
                }
                _formations = value;
            }
        }


        /// <summary>
        /// Отримує або встановлює досвід тренера (у роках).
        /// Повинен бути невід’ємним числом.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо досвід є від’ємним числом.
        /// </exception>
        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Experience cannot be negative.");
                }
                if (value > (_age - 28))
                {
                    throw new ArgumentOutOfRangeException($"Experience cannot be more than {_age - 28} years.");
                }
                _experience = value;
            }
        }


        /// <summary>
        /// Ініціалізує новий екземпляр класу <see cref="Coach"/> з указаними ім’ям, віком, зростом та досвідом.
        /// Список формацій ініціалізується як порожній.
        /// </summary>
        /// <param name="name"> ім’я тренера. Не може бути null, порожнім або складатися лише з пробілів.</param>
        /// <param name="age"> вік тренера (від 28 до 80 років).</param>
        /// <param name="height"> зріст у сантиметрах (від 140 до 220).</param>
        /// <param name="experience"> досвід у роках. Не може бути від’ємним.</param>
        /// <param name="formations"> список доступних схем. Не може бути null.</param>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо ім’я є недійсним (null, порожнє або складається лише з пробілів).
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо вік не в межах від 28 до 80 років, 
        /// якщо зріст не в межах від 140 до 220 см, 
        /// або якщо досвід є від’ємним числом.
        /// </exception> 
        public Coach(string name, int age, int height, int experience, List<FormationType> formations)
            : base(name, age, height)
        {
            Experience = experience;
            Formations = formations;

            coaches.Add(this);
        }

        /// <summary>
        /// Повертає рядкове представлення тренера (його ім’я).
        /// </summary>
        /// <returns> ім’я тренера у вигляді рядка.</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Видаляє поточного тренера зі списку тренерів, якщо він не закріплений за жодною командою.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Виникає, якщо тренер вже прикріплений до команди (Team не є null).
        /// </exception>
        public void Delete()
        {
            if (Team != null)
            {
                throw new InvalidOperationException("Coach cannot be deleted while assigned to a team.");
            }
            coaches.Remove(this);
        }

        /// <summary>
        /// Повертає список усіх створених тренерів.
        /// </summary>
        /// <returns> список об'єктів <see cref="Coach"/>.</returns>
        public static List<Coach> GetAllCoaches()
        {
            return coaches;
        }

    }
}
