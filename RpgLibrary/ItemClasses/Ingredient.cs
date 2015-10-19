using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.ItemClasses
{
    public class Ingredient : BaseItem
    {
        #region Field region



        #endregion

        #region Property region



        #endregion

        #region Constructor region

        public Ingredient(
            string ingredientName,
            string ingredientType,
            int price,
            float weight)
            : base(ingredientName, ingredientType, price, weight, null)
        {

        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region

        public override object Clone()
        {
            Ingredient ingredient = new Ingredient(Name, Type, Price, Weight);

            return ingredient;
        }

        #endregion

    }
}
