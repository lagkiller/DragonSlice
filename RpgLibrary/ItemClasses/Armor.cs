﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.ItemClasses
{
    public class Armor : BaseItem
    {
        #region Field region

        ArmorLocation location;

        int defenseValue;
        int defenseModifier;

        #endregion

        #region Property region

        public ArmorLocation Location
        {
            get
            {
                return location;
            }
            protected set
            {
                location = value;
            }
        }

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

        #region Constructor Region

        public Armor(
            string armorName,
            string armorType,
            int price,
            float weight,
            ArmorLocation location,
            int defenseValue,
            int defenseModifier,
            params Type[] allowableClasses)
            : base(armorName, armorType, price, weight, allowableClasses)
        {
            Location = location;
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

            Armor armor = new Armor(
                Name,
                Type,
                Price,
                Weight,
                Location,
                DefenseValue,
                DefenseModifier,
                allowedClasses);

            return armor;
        }

        public override string ToString()
        {
            string armorString = base.ToString() + ", ";
            armorString += Location.ToString() + ", ";
            armorString += DefenseValue.ToString() + ", ";
            armorString += DefenseModifier.ToString();

            foreach (Type t in allowableClasses)
            {
                armorString += ", " + t.Name;
            }

            return armorString;
        }

        #endregion
    }
}
