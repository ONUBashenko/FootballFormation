using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballFormation.Classes.PositionInFormation;
using static FootballFormation.Classes.FormationHelper;

namespace FootballFormation.Classes
{
    public class FormationExtensions
    {
        /// <summary>
        /// Створює словник позицій у формації для заданого типу формації.
        /// Включає воротаря, захисників, півзахисників та нападників.
        /// </summary>
        /// <param name="formationName"> тип формації (наприклад, FourFourTwo).</param>
        /// <returns> словник з позиціями у формації та їх активністю (true).</returns>
        public static Dictionary<PositionInFormation, bool> SetPositionsInFormation(FormationType formationName)
        {
            var PositionsInFormation = new Dictionary<PositionInFormation, bool>();

            PositionsInFormation[Goalkeeper] = true;
            SetDefenders(PositionsInFormation, formationName);
            SetMidfielders(PositionsInFormation, formationName);
            SetForwards(PositionsInFormation, formationName);

            return PositionsInFormation;
        }

        /// <summary>
        /// Повертає кількість гравців у кожній лінії (захист, півзахист, напад)
        /// відповідно до вказаного типу формації.
        /// </summary>
        /// <param name="formationName">Тип формації.</param>
        /// <returns> список з трьох чисел: захисники, півзахисники, нападники.</returns>
        public static List<int> GetNumberOfPlayersInLine(FormationType formationName)
        {
            List<int> playersInLine = GetFormationString(formationName)
                .Split('-')
                .Select(int.Parse)
                .ToList();

            return playersInLine;
        }

        /// <summary>
        /// Повертає кількість захисників з переданого списку розподілу гравців по лініях.
        /// </summary>
        /// <param name="playersInLine"> список кількостей гравців у кожній лінії.</param>
        /// <returns> кількість захисників.</returns>
        public static int HowManyDefenders(List<int> playersInLine)
        {
            return playersInLine.First();
        }

        /// <summary>
        /// Повертає кількість півзахисників з переданого списку розподілу гравців по лініях.
        /// </summary>
        /// <param name="playersInLine"> список кількостей гравців у кожній лінії.</param>
        /// <returns> кількість півзахисників.</returns>
        public static int HowManyMidfielders(List<int> playersInLine)
        {
            return playersInLine[1];
        }

        /// <summary>
        /// Повертає кількість нападників з переданого списку розподілу гравців по лініях.
        /// </summary>
        /// <param name="playersInLine"> список кількостей гравців у кожній лінії.</param>
        /// <returns> кількість нападників.</returns>
        public static int HowManyForwards(List<int> playersInLine)
        {
            return playersInLine.Last();
        }

        /// <summary>
        /// Додає до словника позиції захисників відповідно до заданого типу формації.
        /// </summary>
        /// <param name="PositionsInFormation"> словник позицій, які потрібно заповнити.</param>
        /// <param name="formationName"> тип формації.</param>
        public static void SetDefenders(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            int defendersCount = HowManyDefenders(GetNumberOfPlayersInLine(formationName));

            if (defendersCount == 3)
            {
                PositionsInFormation[CenterBackLeft] = true;
                PositionsInFormation[CenterBackCentral] = true;
                PositionsInFormation[CenterBackRight] = true;
            }
            else if (defendersCount == 4)
            {
                PositionsInFormation[LeftBack] = true;
                PositionsInFormation[CenterBackLeft] = true;
                PositionsInFormation[CenterBackRight] = true;
                PositionsInFormation[RightBack] = true;
            }
            else if (defendersCount == 5)
            {
                PositionsInFormation[LeftBack] = true;
                PositionsInFormation[CenterBackLeft] = true;
                PositionsInFormation[CenterBackCentral] = true;
                PositionsInFormation[CenterBackRight] = true;
                PositionsInFormation[RightBack] = true;
            }
        }

        /// <summary>
        /// Додає до словника позиції півзахисників відповідно до заданого типу формації.
        /// </summary>
        /// <param name="PositionsInFormation"> словник позицій, які потрібно заповнити.</param>
        /// <param name="formationName"> тип формації.</param>
        public static void SetMidfielders(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            int midfieldersCount = HowManyMidfielders(GetNumberOfPlayersInLine(formationName));

            if (midfieldersCount == 2)
            {
                PositionsInFormation[CenterMidfielderLeft] = true;
                PositionsInFormation[CenterMidfielderRight] = true;
            }
            else if (midfieldersCount == 3)
            {
                PositionsInFormation[CenterMidfielderLeft] = true; 
                PositionsInFormation[CenterMidfielderCentral] = true; 
                PositionsInFormation[CenterMidfielderRight] = true; 
            }
            else if (midfieldersCount == 4)
            {
                PositionsInFormation[LeftMidfielder] = true;
                PositionsInFormation[CenterMidfielderLeft] = true; 
                PositionsInFormation[CenterMidfielderRight] = true;
                PositionsInFormation[RightMidfielder] = true;
            }
            else if (midfieldersCount == 5)
            {
                PositionsInFormation[LeftMidfielder] = true;
                PositionsInFormation[CenterMidfielderLeft] = true;
                PositionsInFormation[CenterMidfielderRight] = true;
                PositionsInFormation[RightMidfielder] = true;
            }
        }

        /// <summary>
        /// Додає до словника позиції нападників відповідно до заданого типу формації.
        /// </summary>
        /// <param name="PositionsInFormation"> словник позицій, які потрібно заповнити.</param>
        /// <param name="formationName"> тип формації.</param>
        public static void SetForwards(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            int forwardsCount = HowManyForwards(GetNumberOfPlayersInLine(formationName));

            if (forwardsCount == 1)
            {
                PositionsInFormation[StrikerCentral] = true;
            }
            else if (forwardsCount == 2)
            {
                PositionsInFormation[StrikerLeft] = true;
                PositionsInFormation[StrikerRight] = true;
            }
            else if (forwardsCount == 3)
            {
                PositionsInFormation[LeftWinger] = true;
                PositionsInFormation[StrikerCentral] = true;
                PositionsInFormation[RightWinger] = true;
            }
            else if (forwardsCount == 4)
            {
                PositionsInFormation[LeftWinger] = true;
                PositionsInFormation[StrikerLeft] = true;
                PositionsInFormation[StrikerRight] = true;
                PositionsInFormation[RightWinger] = true;
            }
        }
    }
}
