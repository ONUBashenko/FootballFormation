using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static FootballFormation.Classes.FormationExtensions;

namespace FootballFormation.Classes
{
    /// <summary>
    /// Перелічення можливих типів футбольних формацій.
    /// </summary>
    public enum FormationType
    {
        //3-4-3
        ThreeFourThree,
        //3-5-2
        ThreeFiveTwo,
        //4-2-4
        FourTwoFour,
        //4-3-3
        FourThreeThree,
        //4-4-2
        FourFourTwo,
        //4-5-1
        FourFiveOne,
        //5-2-3
        FiveTwoThree,
        //5-3-2
        FiveThreeTwo,
        //5-4-1
        FiveFourOne
    }

    /// <summary>
    /// Представляє футбольну формацію, яка містить тип, список позицій та гравців на позиціях.
    /// </summary>
    public class Formation
    {
        private FormationType _formationName;
        private Dictionary<PositionInFormation, bool> _positionsInFormation = new Dictionary<PositionInFormation, bool>();
        private Dictionary<PositionInFormation, Player> _playersOnPositions = new Dictionary<PositionInFormation, Player>();

        /// <summary>
        /// Отримує або встановлює тип формації (наприклад, 4-4-2).
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо передано неіснуючий тип формації.
        /// </exception>
        public FormationType FormationName
        {
            get {return _formationName;}
            set
            {
                if (!Enum.IsDefined(typeof(FormationType), value))
                {
                    throw new ArgumentException("Invalid formation type.");
                }
                _formationName = value;
            }
        }

        /// <summary>
        /// Отримує або встановлює позиції у формації.
        /// Ключ — позиція, значення — активність позиції (true — використовується).
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо словник порожній або null.
        /// </exception>
        public Dictionary<PositionInFormation, bool> PositionsInFormation
        {
            get {return _positionsInFormation;}
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Positions in formation cannot be null or empty.");
                }
                _positionsInFormation = value;
            }
        }

        /// <summary>
        /// Отримує або встановлює гравців, призначених на конкретні позиції у формації.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Виникає, якщо:
        /// - Словник null;
        /// - Кількість гравців не дорівнює 11;
        /// - Позиція, вказана у словнику, не існує у PositionsInFormation.
        /// </exception>
        public Dictionary<PositionInFormation, Player> PlayersOnPositions
        {
            get { return _playersOnPositions; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Players on positions cannot be null.");
                }
                if (value.Count != 11)
                {
                    throw new ArgumentException("There must be exactly 11 players in formation.");
                }
                foreach (var position in value.Keys)
                {
                    if (!PositionsInFormation.ContainsKey(position))
                    {
                        throw new ArgumentException($"Position {position} does not exist in this formation.");
                    }
                }
                _playersOnPositions = value;
            }
        }

        /// <summary>
        /// Ініціалізує нову формацію з відповідним типом та розподілом гравців.
        /// </summary>
        /// <param name="formationName"> тип формації (наприклад, 4-4-2).</param>
        /// <param name="playersOnPositions"> гравці, розміщені по позиціях.</param>
        public Formation(FormationType formationName, Dictionary<PositionInFormation, Player> playersOnPositions)
        {
            FormationName = formationName;
            PositionsInFormation = SetPositionsInFormation(formationName);
            PlayersOnPositions = playersOnPositions;
        }
    }
}
