using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

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
        private List<FormationType> _formations;
        private int _experience;

        /// <summary>
        /// Отримує або встановлює вік тренера.
        /// Має бути в межах від 28 до 80 років включно.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо вік менше 28 або більше 80 років.
        /// </exception>
        public override int Age
        {
            get {return _age;}
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
            get {return _formations;}
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Formations cannot be null.");
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
        /// <exception cref="ArgumentException">
        /// Виникає, якщо ім’я є недійсним (null, порожнє або складається лише з пробілів).
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо вік не в межах від 28 до 80 років, 
        /// якщо зріст не в межах від 140 до 220 см, 
        /// або якщо досвід є від’ємним числом.
        /// </exception> 
        public Coach(string name, int age, int height, int experience)
            : base(name, age, height)
        {
            Experience = experience;
            Formations = new List<FormationType>();
        }


        /// <summary>
        /// Додає тактичну схему до списку формацій тренера.
        /// </summary>
        /// <param name="formation"> формація, яку потрібно додати.</param>
        /// <exception cref="ArgumentNullException">
        /// Виникає, якщо <paramref name="formation"/> дорівнює null.
        /// </exception>
        public void AddFormation(FormationType formation)
        {
            if (formation == null)
            {
                throw new ArgumentNullException("Formation cannot be null.");
            }
            _formations.Add(formation);
        }

        /// <summary>
        /// Видаляє тактичну схему зі списку формацій тренера.
        /// </summary>
        /// <param name="formation"> формація, яку потрібно видалити.</param>
        /// <exception cref="ArgumentNullException">
        /// Виникає, якщо <paramref name="formation"/> дорівнює null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо формація не знайдена у списку тренера.
        /// </exception>
        public void RemoveFormation(FormationType formation)
        {
            if (formation == null)
            {
                throw new ArgumentNullException("Formation cannot be null.");
            }
            if (!_formations.Contains(formation))
            {
                throw new ArgumentException("Formation not found in the coach's list.");
            }
            _formations.Remove(formation);
        }
    }
}
