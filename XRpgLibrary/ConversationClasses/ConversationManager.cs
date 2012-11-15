using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.ConversationClasses
{
    public class ConversationManager
    {
        #region Field region

        readonly Dictionary<string, Conversation> conversations;

        #endregion

        #region Property region

        public Dictionary<string, Conversation> Conversations
        {
            get
            {
                return conversations;
            }
        }

        #endregion

        #region Constructor region

        public ConversationManager()
        {
            conversations = new Dictionary<string, Conversation>();
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region



        #endregion

    }
}
