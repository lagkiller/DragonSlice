using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.QuestClasses
{
    public class QuestManager
    {
        #region Field region

        readonly Dictionary<string, Quest> quests;

        #endregion

        #region Property region

        public Dictionary<string, Quest> Quests
        {
            get
            {
                return quests;
            }
        }

        #endregion

        #region Constructor region

        public QuestManager()
        {
            quests = new Dictionary<string, Quest>();
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region



        #endregion

    }
}
