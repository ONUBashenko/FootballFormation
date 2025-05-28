using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Formation
{
    public class FormationHelper
    {
        private static readonly Dictionary<FormationType, string> FormationDictionary = new Dictionary<FormationType, string>()
        {
            {FormationType.FourFourTwo, "4-4-2" },
            {FormationType.ThreeFiveTwo, "3-5-2" },
            {FormationType.FourThreeThree, "4-3-3" }
        };

        private static readonly Dictionary<string, FormationType> ReverseDictionary = FormationDictionary
            .ToDictionary(pair => pair.Value, pair => pair.Key);

        public static string GetFormationString(FormationType formationName)
        {
            return FormationDictionary.TryGetValue(formationName, out var result) ? result : "Unknown";
        }

        public static bool TryParseFormation(string formationString, out FormationType formationName)
        {
            return ReverseDictionary.TryGetValue(formationString, out formationName);
        }
    }
}
