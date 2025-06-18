using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballFormation.Classes.PositionType;

namespace FootballFormation.Classes
{
    /// <summary>
    /// Клас для представлення позиції в тактичній схемі.
    /// Містить властивості: назва позиції (PositionName) та її специфіка (PositionSpecific).
    /// </summary>
    public class PositionInFormation
    {
        public enum SpecificType
        {
            None,
            Left,
            Right,
            Central
        }

        private PositionType _positionName;
        private SpecificType _positionSpecific;

        /// <summary>
        /// Отримує або встановлює позицію гравця.
        /// Має бути дійсним значенням з перерахування <see cref="PositionType"/>.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо позиція не є дійсним значенням з перерахування PositionType.
        /// </exception>
        public PositionType PositionName
        {
            get {return _positionName;}
            set 
            {
                if (!Enum.IsDefined(typeof(PositionType), value))
                {
                    throw new ArgumentOutOfRangeException("Invalid position type.");
                }
                _positionName = value;
            }
        }

        /// <summary>
        /// Отримує або встановлює специфіку позиції гравця.
        /// Має бути дійсним значенням з перерахування <see cref="SpecificType"/>.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо специфіка позиції не є дійсним значенням з перерахування SpecificType.
        /// </exception>
        public SpecificType PositionSpecific
        {
            get {return _positionSpecific;}
            set 
            {
                if(!Enum.IsDefined(typeof(SpecificType), value))
                {
                    throw new ArgumentOutOfRangeException("Invalid specific position type.");
                }
                if(value != SpecificType.None)
                {
                    if(_positionName != PositionType.CB && _positionName != PositionType.CM && _positionName != PositionType.ST)
                    {
                        throw new ArgumentOutOfRangeException("Specific type can only be used with CB, CM, or ST positions.");
                    }
                }
                _positionSpecific = value;
            }
        }

        /// <summary>
        /// Ініціалізує новий екземпляр класу <see cref="PositionInFormation"/> з указаною позицією та її специфікою.
        /// </summary>
        /// <param name="positionName"> позиція гравця (одне з допустимих значень <see cref="PositionType"/>).</param>
        /// <param name="positionSpecific"> специфіка позиції (одне з допустимих значень <see cref="SpecificType"/>; за замовчуванням — <see cref="SpecificType.None"/>).</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо позиція або специфіка недійсна.
        /// </exception>
        private PositionInFormation(PositionType positionName, SpecificType positionSpecific = SpecificType.None)
        {
            PositionName = positionName;
            PositionSpecific = positionSpecific;
        }

        public static readonly PositionInFormation Goalkeeper = new PositionInFormation(GK);
        public static readonly PositionInFormation LeftBack = new PositionInFormation(LB);
        public static readonly PositionInFormation RightBack = new PositionInFormation(RB);
        public static readonly PositionInFormation CenterBackLeft = new PositionInFormation(CB, SpecificType.Left);
        public static readonly PositionInFormation CenterBackRight = new PositionInFormation(CB, SpecificType.Right);
        public static readonly PositionInFormation CenterBackCentral = new PositionInFormation(CB, SpecificType.Central);
        public static readonly PositionInFormation CenterMidfielderLeft = new PositionInFormation(CM, SpecificType.Left);
        public static readonly PositionInFormation CenterMidfielderRight = new PositionInFormation(CM, SpecificType.Right);
        public static readonly PositionInFormation CenterMidfielderCentral = new PositionInFormation(CM, SpecificType.Central);
        public static readonly PositionInFormation LeftMidfielder = new PositionInFormation(LM);
        public static readonly PositionInFormation RightMidfielder = new PositionInFormation(RM);
        public static readonly PositionInFormation LeftWinger = new PositionInFormation(LW);
        public static readonly PositionInFormation RightWinger = new PositionInFormation(RW);
        public static readonly PositionInFormation StrikerLeft = new PositionInFormation(ST, SpecificType.Left);
        public static readonly PositionInFormation StrikerRight = new PositionInFormation(ST, SpecificType.Right);
        public static readonly PositionInFormation StrikerCentral = new PositionInFormation(ST, SpecificType.Central);
    }
}
