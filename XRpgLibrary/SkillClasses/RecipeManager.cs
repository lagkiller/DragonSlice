using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.SkillClasses
{
    public class RecipeManager
    {
        #region Field region

        readonly Dictionary<string, Recipe> recipies;

        #endregion

        #region Property region

        public Dictionary<string, Recipe> Recipies
        {
            get
            {
                return recipies;
            }
        }

        #endregion

        #region Constructor region

        public RecipeManager()
        {
            recipies = new Dictionary<string, Recipe>();
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region



        #endregion

    }
}
