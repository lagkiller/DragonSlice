using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.SkillClasses
{
    public class SkillData
    {
        #region Field region

        public string Name;
        public string PrimaryAttribute;
        public Dictionary<string, int> ClassModifiers;

        #endregion

        #region Constructor region

        public SkillData()
        {
            ClassModifiers = new Dictionary<string, int>();
        }

        #endregion

        #region Virtual Method region

        public override string ToString()
        {
            string toString = Name + ", ";
            toString += PrimaryAttribute;

            foreach (string s in ClassModifiers.Keys)
            {
                toString += ", " + s + "+" + ClassModifiers[s].ToString();
            }

            return toString;
        }

        #endregion

    }
}
