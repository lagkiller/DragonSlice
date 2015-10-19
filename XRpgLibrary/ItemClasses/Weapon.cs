﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.ItemClasses
{
    public class Weapon : BaseItem
    {
        #region Field region

        Hands hands;
        int attackValue;
        int attackModifier;
        int damageValue;
        int damageModifier;

        #endregion

        #region Property region

        public Hands NumberHands
        {
            get
            {
                return hands;
            }
            protected set
            {
                hands = value;
            }
        }

        public int AttackValue
        {
            get
            {
                return attackValue;
            }
            protected set
            {
                attackValue = value;
            }
        }

        public int AttackModifier
        {
            get
            {
                return attackModifier;
            }
            protected set
            {
                attackModifier = value;
            }
        }

        public int DamageValue
        {
            get
            {
                return damageValue;
            }
            protected set
            {
                damageValue = value;
            }
        }

        public int DamageModifier
        {
            get
            {
                return damageModifier;
            }
            protected set
            {
                damageModifier = value;
            }
        }

        #endregion

        #region Constructor region

        public Weapon(
            string weaponName,
            string weaponType,
            int price,
            float weight,
            Hands hands,
            int attackValue,
            int attackModifier,
            int damageValue,
            int damageModifier,
            params string[] allowableClasses)
            : base(weaponName, weaponType, price, weight, allowableClasses)
        {
            NumberHands = hands;
            AttackValue = attackValue;
            AttackModifier = attackModifier;
            DamageValue = damageValue;
            DamageModifier = damageModifier;
        }

        #endregion

        #region Abstract method region

        public override object Clone()
        {
            string[] allowedClasses = new string[allowableClasses.Count];

            for (int i = 0; i < allowableClasses.Count; i++)
            {
                allowedClasses[i] = allowableClasses[i];
            }

            Weapon weapon = new Weapon(
                Name,
                Type,
                Price,
                Weight,
                NumberHands,
                AttackValue,
                AttackModifier,
                DamageValue,
                DamageModifier,
                allowedClasses);

            return weapon;
        }

        public override string ToString()
        {
            string weaponString = base.ToString() + ", ";
            weaponString += NumberHands.ToString() + ", ";
            weaponString += AttackValue.ToString() + ", ";
            weaponString += AttackModifier.ToString() + ", ";
            weaponString += DamageValue.ToString() + ", ";
            weaponString += DamageModifier.ToString();

            foreach (string s in allowableClasses)
            {
                weaponString += ", " + s;
            }

            return weaponString;
        }

        #endregion
    }
}
