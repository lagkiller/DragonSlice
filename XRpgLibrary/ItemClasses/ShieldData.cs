using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.ItemClasses
{
    public class ShieldData
    {
        #region Field region

        public string Name;
        public string Type;
        public int Price;
        public float Weight;
        public bool Equipped;
        public int DefenseValue;
        public int DefenseModifier;
        public string[] AllowableClasses;

        #endregion

        #region Constructor region

        public ShieldData()
        {

        }

        #endregion

        #region Method region

        public override string ToString()
        {
            string toString = Name + ", ";
            toString += Type + ", ";
            toString += Price.ToString() + ", ";
            toString += Weight.ToString() + ", ";
            toString += DefenseValue + ", ";
            toString += DefenseModifier.ToString();

            foreach (string s in AllowableClasses)
            {
                toString += ", " + s;
            }

            return toString;
        }

        #endregion
    }
}
