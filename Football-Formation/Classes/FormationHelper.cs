using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormation.Classes
{
    public class FormationHelper
    {
        /// <summary>
        /// Словник, який зіставляє тип формації (`FormationType`) з її текстовим представленням (наприклад, "4-4-2").
        /// </summary>
        private static readonly Dictionary<FormationType, string> FormationDictionary = new Dictionary<FormationType, string>()
        {
            {FormationType.ThreeFourThree, "3-4-3" },
            {FormationType.ThreeFiveTwo, "3-5-2" },
            {FormationType.FourTwoFour, "4-2-4" },
            {FormationType.FourThreeThree, "4-3-3" },
            {FormationType.FourFourTwo, "4-4-2" },
            {FormationType.FourFiveOne, "4-5-1" },
            {FormationType.FiveTwoThree, "5-2-3" },
            {FormationType.FiveThreeTwo, "5-3-2" },
            {FormationType.FiveFourOne, "5-4-1" }
        };

        /// <summary>
        /// Зворотний словник, який зіставляє текстове представлення формації з її типом (`FormationType`).
        /// </summary>
        private static readonly Dictionary<string, FormationType> ReverseDictionary = FormationDictionary
            .ToDictionary(pair => pair.Value, pair => pair.Key);

        /// <summary>
        /// Повертає текстове представлення формації за її типом.
        /// </summary>
        /// <param name="formationName"> тип формації (наприклад, FormationType.FourFourTwo).</param>
        /// <returns> рядок формату "4-4-2" або "Unknown", якщо формація не знайдена.</returns>
        public static string GetFormationString(FormationType formationName)
        {
            return FormationDictionary.TryGetValue(formationName, out var result) ? result : "Unknown";
        }

        /// <summary>
        /// Перетворює текстове представлення формації (наприклад, "4-4-2") у відповідне значення переліку `FormationType`.
        /// </summary>
        /// <param name="formationString"> рядок з формацією.</param>
        /// <param name="formationName"> результат розбору у вигляді FormationType, якщо вдалося.</param>
        /// <returns> True, якщо розбір успішний; інакше — false.</returns>
        public static bool TryParseFormation(string formationString, out FormationType formationName)
        {
            return ReverseDictionary.TryGetValue(formationString, out formationName);
        }
    }
}
