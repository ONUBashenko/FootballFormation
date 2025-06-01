using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormation
{
    public class FormationHelper
    {
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

        /*private static readonly Dictionary<string, FormationType> ReverseDictionary = FormationDictionary
            .ToDictionary(pair => pair.Value, pair => pair.Key);
        */
        public static string GetFormationString(FormationType formationName)
        {
            return FormationDictionary.TryGetValue(formationName, out var result) ? result : "Unknown";
        }

       /* public static bool TryParseFormation(string formationString, out FormationType formationName)
        {
            return ReverseDictionary.TryGetValue(formationString, out formationName);
        } */
    }
}
