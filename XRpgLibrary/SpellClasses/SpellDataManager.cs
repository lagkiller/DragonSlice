using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.SpellClasses
{
    public class SpellDataManager
    {
        #region Field region

        readonly Dictionary<string, SpellData> spellData;

        #endregion

        #region Property region

        public Dictionary<string, SpellData> SpellData
        {
            get
            {
                return spellData;
            }
        }

        #endregion

        #region Constructor region

        public SpellDataManager()
        {
            spellData = new Dictionary<string, SpellData>();
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region



        #endregion

    }
}
