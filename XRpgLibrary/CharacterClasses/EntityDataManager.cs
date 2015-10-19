using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.CharacterClasses
{
    public class EntityDataManager
    {
        #region Field region

        readonly Dictionary<string, EntityData> entityData = new Dictionary<string, EntityData>();

        #endregion

        #region Property region

        public Dictionary<string, EntityData> EntityData
        {
            get
            {
                return entityData;
            }
        }

        #endregion

        #region Constructor region



        #endregion

        #region Method region



        #endregion
    }
}
