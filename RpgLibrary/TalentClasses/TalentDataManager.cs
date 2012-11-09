using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.TalentClasses
{
    public class TalentDataManager
    {
        #region Field region

        readonly Dictionary<string, TalentData> talentData;

        #endregion

        #region Property region

        public Dictionary<string, TalentData> TalentData
        {
            get
            {
                return talentData;
            }
        }

        #endregion

        #region Constructor region

        public TalentDataManager()
        {
            talentData = new Dictionary<string, TalentData>();
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region



        #endregion

    }
}
