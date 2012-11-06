using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.ItemClasses
{
    public class Shield : BaseItem
    {
        #region Field region

        int defenseValue;
        int defenseModifier;

        #endregion

        #region Property region

        public int DefenseValue
        {
            get
            {
                return defenseValue;
            }
            protected set
            {
                defenseValue = value;
            }
        }

        public int DefenseModifier
        {
            get
            {
                return defenseModifier;
            }
            protected set
            {
                defenseModifier = value;
            }
        }

        #endregion

        #region Constructor region

        public Shield(
            string shieldName,
            string shieldType,
            int price,
            float weight,
            int defenseValue,
            int defenseModifier,
            params Type[] allowableClasses)
            : base(shieldName, shieldType, price, weight, allowableClasses)
        {
            DefenseValue = defenseValue;
            DefenseModifier = defenseModifier;
        }

        #endregion

        #region Abstract method region

        public override object Clone()
        {
            Type[] allowedClasses = new Type[allowableClasses.Count];

            for (int i = 0; i < allowableClasses.Count; i++)
            {
                allowedClasses[i] = allowableClasses[i];
            }

            Shield shield = new Shield(
                Name,
                Type,
                Price,
                Weight,
                DefenseValue,
                DefenseModifier,
                allowedClasses);

            return shield;
        }

        public override string ToString()
        {
            string shieldString = base.ToString() + ", ";
            shieldString += DefenseValue.ToString() + ", ";
            shieldString += DefenseModifier.ToString();

            foreach (Type t in allowableClasses)
            {
                shieldString += ", " + t.Name;
            }

            return shieldString;
        }

        #endregion
    }
}
