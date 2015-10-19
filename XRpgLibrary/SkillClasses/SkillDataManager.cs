using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.SkillClasses
{
    public class SkillDataManager
    {
        #region Field region

        readonly Dictionary<string, SkillData> skillData;

        #endregion

        #region Property region

        public Dictionary<string, SkillData> SkillData
        {
            get
            {
                return skillData;
            }
        }

        #endregion

        #region Constructor region

        public SkillDataManager()
        {
            skillData = new Dictionary<string, SkillData>();
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region



        #endregion

    }
}
