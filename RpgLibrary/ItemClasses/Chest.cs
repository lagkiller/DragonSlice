using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RpgLibrary.TrapClasses;

namespace RpgLibrary.ItemClasses
{
    public class Chest : BaseItem
    {
        #region Field region

        static Random Random = new Random();
        ChestData chestData;

        #endregion

        #region Property region

        public bool IsLocked
        {
            get
            {
                return chestData.IsLocked;
            }
        }

        public bool IsTrapped
        {
            get
            {
                return chestData.IsTrapped;
            }
        }

        public int Gold
        {
            get
            {
                if (chestData.MinGold == 0 && chestData.MaxGold == 0)
                {
                    return 0;
                }

                int gold = Random.Next(chestData.MinGold, chestData.MaxGold);
                chestData.MinGold = 0;
                chestData.MaxGold = 0;

                return gold;
            }
        }

        #endregion

        #region Constructor region

        public Chest(ChestData data)
            : base(data.Name, "", 0, 0)
        {
            this.chestData = data;
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region

        public override object Clone()
        {
            ChestData data = new ChestData();
            data.Name = chestData.Name;
            data.IsLocked = chestData.IsLocked;
            data.IsTrapped = chestData.IsTrapped;
            data.DifficultyLevel = chestData.DifficultyLevel;
            data.TrapName = chestData.TrapName;
            data.KeyName = chestData.KeyName;
            data.KeyType = chestData.KeyType;
            data.KeysRequired = chestData.KeysRequired;
            data.MinGold = chestData.MinGold;
            data.MaxGold = chestData.MaxGold;

            foreach (KeyValuePair<string, string> pair in chestData.ItemCollection)
            {
                data.ItemCollection.Add(pair.Key, pair.Value);
            }

            Chest chest = new Chest(data);
            return chest;
        }

        #endregion

    }
}
