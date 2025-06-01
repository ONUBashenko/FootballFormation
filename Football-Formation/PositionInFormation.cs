using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormation
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

        private Player.PositionType _positionName;
        private SpecificType _positionSpecific;

        /// <summary>
        /// Отримує або встановлює позицію гравця.
        /// Має бути дійсним значенням з перерахування <see cref="PositionType"/>.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо позиція не є дійсним значенням з перерахування PositionType.
        /// </exception>
        public Player.PositionType PositionName
        {
            get {return _positionName;}
            set 
            {
                if (!Enum.IsDefined(typeof(Player.PositionType), value))
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
                /*if(value == SpecificType.Left || value == SpecificType.Right)
                {
                }*/
                _positionSpecific = value;
            }
        }

        /// <summary>
        /// Ініціалізує новий екземпляр класу <see cref="PositionInFormation"/> з указаною позицією та її специфікою.
        /// </summary>
        /// <param name="positionName"> позиція гравця (одне з допустимих значень <see cref="Player.PositionType"/>).</param>
        /// <param name="positionSpecific"> специфіка позиції (одне з допустимих значень <see cref="SpecificType"/>; за замовчуванням — <see cref="SpecificType.None"/>).</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Виникає, якщо позиція або специфіка недійсна.
        /// </exception>
        public PositionInFormation(Player.PositionType positionName, SpecificType positionSpecific = SpecificType.None)
        {
            PositionName = positionName;
            PositionSpecific = positionSpecific;
        }
    }
}
