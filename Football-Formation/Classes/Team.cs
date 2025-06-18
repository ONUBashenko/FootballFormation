using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormation.Classes
{
    /// <summary>
    /// Представляє футбольну команду, яка містить гравців та тренера.
    /// </summary>
    public class Team
    {
        private string _name;
        private string _country;
        private Coach _teamCoach;
        private List<Player> _players;
        private static List<Team> teams = new List<Team>();

        /// <summary>
        /// Отримує або встановлює назву команди.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо значення є порожнім або складається лише з пробілів.
        /// </exception>
        public string Name
        {
            get {return _name;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Team name cannot be empty.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Отримує або встановлює країну команди.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо значення є порожнім або складається лише з пробілів.
        /// </exception>
        public string Country
        {
            get {return _country;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Country cannot be empty.");
                }
                _country = value;
            }
        }

        /// <summary>
        /// Отримує або встановлює головного тренера команди.
        /// </summary>
        /// <exception cref="ArgumentNullException"> 
        /// Виникає якщо тренер null. 
        /// </exception>
        /// <exception cref="ArgumentException"> 
        /// Виникає якщо тренер вже закріплений за іншою командою.
        /// </exception>
        public Coach TeamCoach
        {
            get {return _teamCoach;}
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Coach cannot be null.");
                }
                if (value.Team != null)
                {
                    throw new ArgumentException("Coach is already assigned to another team.");
                }
                _teamCoach = value;
            }
        }

        /// <summary>
        /// Отримує або встановлює список гравців команди.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Виникає якщо список гравців null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Виникає якщо кількість гравців менша 11 або більша 25, 
        /// або якщо будь-який гравець вже закріплений за іншою командою.
        /// </exception>
        public List<Player> Players
        {
            get {return _players;}
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Players list cannot be null.");
                }
                if (value.Count < 11 || value.Count > 25)
                {
                    throw new ArgumentException($"A team can have from 11 to 25 players (now {value.Count})");
                }
                foreach (var player in value)
                {
                    if (player.Team != null)
                    {
                        throw new ArgumentException($"Player {player.Name} is already assigned to another team.");
                    }
                }
                _players = value;
            }
        }

        /// <summary>
        /// Ініціалізує новий екземпляр класу <see cref="Team"/>.
        /// </summary>
        /// <param name="name"> назва команди.</param>
        /// <param name="country"> країна команди.</param>
        /// <param name="teamCoach"> головний тренер команди.</param>
        /// <param name="players"> список гравців команди.</param>
        /// <exception cref="ArgumentException">
        /// Виникає якщо вхідні значення некоректні. 
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Виниає якщо тренер або гравці вже закріплені за іншою командою.
        /// </exception>
        public Team(string name, string country, Coach teamCoach, List<Player> players)
        {
            Name = name;
            Country = country;
            TeamCoach = teamCoach;
            Players = players;

            this.Assign();

            teams.Add(this);
        }

        /// <summary>
        /// Призначає тренера та гравців до цієї команди.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Виникає якщо тренер або гравець вже має команду.
        /// </exception>
        private void Assign()
        {
            if (TeamCoach.Team != null)
                throw new InvalidOperationException("Coach already has a team.");

            foreach (var player in Players)
            {
                if (player.Team != null)
                    throw new InvalidOperationException($"Player {player.Name} already has a team.");
            }

            TeamCoach.Team = this;
            foreach (var player in Players)
            {
                player.Team = this;
            }
        }

        /// <summary>
        /// Повертає назву команди у вигляді рядка.
        /// </summary>
        /// <returns> назва команди у вигляді рядка.</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Видаляє команду, відв'язуючи її тренера та гравців.
        /// </summary>
        public void Delete()
        {
            if (TeamCoach != null)
            {
                TeamCoach.Team = null;
            }
            foreach (var player in Players)
            {
                player.Team = null;
            }
            teams.Remove(this);
        }

        /// <summary>
        /// Повертає список усіх створених команд.
        /// </summary>
        /// <returns> список об'єктів <see cref="Team"/>.</returns>
        public static List<Team> GetAllTeams()
        {
            return teams;
        }
    }
}
