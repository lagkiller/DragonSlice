﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XRpgLibrary.SkillClasses;
using XRpgLibrary.CharacterClasses;

namespace XRpgLibrary
{
    public enum DieType { 
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20,
        D100 = 100
    }

    public static class Mechanics
    {
        #region Field region

        static Random random = new Random();

        #endregion

        #region Property region



        #endregion

        #region Constructor region



        #endregion

        #region Method region

        public static int RollDie(DieType die)
        {
            return random.Next(0, (int)die) + 1;
        }

        public static bool UseSkill(Skill skill, Entity entity, DifficultyLevel difficulty)
        {
            bool result = false;
            int target = skill.SkillValue + (int)difficulty;

            foreach (string s in skill.ClassModifiers.Keys)
            {
                if (s == entity.EntityClass)
                {
                    target += skill.ClassModifiers[s];
                }
            }

            foreach (Modifier m in entity.SkillModifiers)
            {
                if (m.Modifying == skill.SkillName)
                {
                    target += m.Amount;
                }
            }

            string lower = skill.PrimaryAttribute.ToLower();

            switch (lower)
            {
                case "strength":
                    target += Skill.AttributeModifier(entity.Strength);
                    break;
                case "dexterity":
                    target += Skill.AttributeModifier(entity.Dexterity);
                    break;
                case "intelligence":
                    target += Skill.AttributeModifier(entity.Intelligence);
                    break;
                case "agility":
                    target += Skill.AttributeModifier(entity.Agility);
                    break;
                case "wisdom":
                    target += Skill.AttributeModifier(entity.Wisdom);
                    break;
                case "vitality":
                    target += Skill.AttributeModifier(entity.Vitality);
                    break;
            }

            if (Mechanics.RollDie(DieType.D100) <= target)
            {
                result = true;
            }

            return result;
        }

        #endregion

        #region Virtual Method region



        #endregion
    }
}
