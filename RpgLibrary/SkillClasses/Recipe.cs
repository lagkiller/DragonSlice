using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.SkillClasses
{
    public struct Ingredients
    {
        #region Field region

        public string IngredientName;
        public ushort AmountRequired;

        #endregion

        #region Property region



        #endregion

        #region Constructor region

        public Ingredients(string recipe, ushort number)
        {
            IngredientName = recipe;
            AmountRequired = number;
        }

        #endregion

        #region Method region



        #endregion
    }

    public class Recipe
    {
        #region Field region

        public string Name;
        public Ingredients[] Ingredients;

        #endregion

        #region Property region



        #endregion

        #region Constructor region

        private Recipe()
        {

        }

        public Recipe(string name, params Ingredients[] ingredients)
        {
            Name = name;
            Ingredients = new Ingredients[ingredients.Length];

            for (int i = 0; i < ingredients.Length; i++)
            {
                Ingredients[i] = ingredients[i];
            }
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region



        #endregion

    }
}
