using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Football_Formation.FormationHelper;

namespace Football_Formation
{
    public class FormationExtensions
    {
        public static Dictionary<PositionInFormation, bool> SetPositionsInFormation(FormationType formationName)
        {
            var PositionsInFormation = new Dictionary<PositionInFormation, bool>();

            PositionsInFormation[GK] = true;
           // SetDefenders(PositionsInFormation /*, HowManyDefenders(formationName)*/);
            //SetMidf
           // SetForwards(PositionsInFormation /*, HowManyForwards(formationName)*/);

            return PositionsInFormation;
        }

        public static List<int> GetNumbers(FormationType formationName)
        {
            List<int> numbers = GetFormationString(formationName)
                .Split('-')
                .Select(int.Parse)
                .ToList();

            return numbers;
        }


        public static int HowManyDefenders(List<int> Numbers)
        {
            return Numbers.First();
        }
        public static int HowManyMidfielders(List<int> Numbers)
        {
            return Numbers[1];
        }
        public static int HowManyForwards(List<int> Numbers)
        {
            return Numbers.Last();
        }

        public static void SetDefenders(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            if (HowManyDefenders(GetNumbers(formationName)) == 3)
            {
                PositionsInFormation[CB] = true; //left
                PositionsInFormation[CB] = true; //central
                PositionsInFormation[CB] = true; //right
            }
            else if (HowManyDefenders(GetNumbers(formationName)) == 4)
            {
                PositionsInFormation[LB] = true;
                PositionsInFormation[CB] = true; //left
                PositionsInFormation[CB] = true; //right
                PositionsInFormation[RB] = true;
            }
            else if (HowManyDefenders(GetNumbers(formationName)) == 5)
            {
                PositionsInFormation[LB] = true;
                PositionsInFormation[CB] = true; //left
                PositionsInFormation[CB] = true; //central
                PositionsInFormation[CB] = true; //right
                PositionsInFormation[RB] = true;
            }
        }

        //public static void SetMidfielders(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)

        public static void SetForwards(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            if (HowManyForwards(GetNumbers(formationName)) == 1)
            {
                PositionsInFormation[ST] = true;
            }
            else if (HowManyForwards(GetNumbers(formationName)) == 2)
            {
                PositionsInFormation[ST] = true; //left
                PositionsInFormation[ST] = true; //right
            }
            else if (HowManyForwards(GetNumbers(formationName)) == 3)
            {
                PositionsInFormation[LW] = true;
                PositionsInFormation[ST] = true;
                PositionsInFormation[RW] = true;
            }
            else if (HowManyForwards(GetNumbers(formationName)) == 4)
            {
                PositionsInFormation[LW] = true;
                PositionsInFormation[ST] = true; //left
                PositionsInFormation[ST] = true; //right
                PositionsInFormation[RW] = true;
            }
        }
    }
}
