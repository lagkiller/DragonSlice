using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.CharacterClasses
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
        public string AgilityFormula;
        public string ManaFormula;

        #endregion

        #region Constructor region

        private EntityData()
        {

        }

        #endregion

        #region Static method region

        public static void ToFile(string filename)
        {

        }

        public static EntityData FromFile(string filename)
        {
            EntityData entity = new EntityData();

            return entity;
        }

        #endregion
    }
}
