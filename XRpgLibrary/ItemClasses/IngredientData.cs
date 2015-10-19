using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.ItemClasses
{
    public class IngredientData
    {
        #region Field region

        public string Name;
        public string Type;
        public int Price;
        public float Weight;

        #endregion

        #region Constructor region

        public IngredientData()
        {

        }

        #endregion

        #region Method region

        public override string ToString()
        {
            string toString = Name + ", ";
            toString += Type + ", ";
            toString += Price.ToString() + ", ";
            toString += Weight.ToString();

            return toString;
        }

        #endregion
    }
}
