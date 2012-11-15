using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.CharacterClasses
{
    public class EntityData
    {
        #region Field region

        public string EntityName;

        public int Strength;
        public int Dexterity;
        public int Intelligence;
        public int Agility;
        public int Wisdom;
        public int Vitality;

        public string HealthFormula;
        public string StaminaFormula;
        public string ManaFormula;

        #endregion

        #region Constructor region

        private EntityData()
        {

        }

        public EntityData(
            string entityName,
            int strength,
            int dexterirty,
            int intelligence,
            int agility,
            int wisdom,
            int vitality,
            string health,
            string stamina,
            string mana)
        {
            EntityName = entityName;
            Strength = strength;
            Dexterity = dexterirty;
            Intelligence = intelligence;
            Agility = agility;
            Wisdom = wisdom;
            Vitality = vitality;
            HealthFormula = health;
            StaminaFormula = stamina;
            ManaFormula = mana;
        }

        #endregion

        #region Method region

        public override string ToString()
        {
            string toString = EntityName + ", ";
            toString += Strength.ToString() + ", ";
            toString += Dexterity.ToString() + ", ";
            toString += Intelligence.ToString() + ", ";
            toString += Agility.ToString() + ", ";
            toString += Wisdom.ToString() + ", ";
            toString += Vitality.ToString() + ", ";
            toString += HealthFormula + ", ";
            toString += StaminaFormula + ", ";
            toString += ManaFormula;

            return toString;
        }

        public object Clone()
        {
            EntityData data = new EntityData();

            data.EntityName = this.EntityName;
            data.Strength = this.Strength;
            data.Dexterity = this.Dexterity;
            data.Intelligence = this.Intelligence;
            data.Agility = this.Agility;
            data.Wisdom = this.Wisdom;
            data.Vitality = this.Vitality;
            data.HealthFormula = this.HealthFormula;
            data.StaminaFormula = this.StaminaFormula;
            data.ManaFormula = this.ManaFormula;

            return data;
        }

        #endregion
    }
}
