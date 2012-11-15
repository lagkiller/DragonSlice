using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.ItemClasses
{
    public class Backpack
    {
        #region Field region

        readonly List<GameItem> items;

        #endregion

        #region Property region

        public List<GameItem> Items
        {
            get
            {
                return items;
            }
        }

        public int Capacity
        {
            get
            {
                return items.Count;
            }
        }

        #endregion

        #region Constructor region

        public Backpack()
        {
            items = new List<GameItem>();
        }

        #endregion

        #region Method region

        public void AddItem(GameItem gameItem)
        {
            items.Add(gameItem);
        }

        public void RemoveItem(GameItem gameItem)
        {
            items.Remove(gameItem);
        }

        #endregion

        #region Virtual Method region



        #endregion

    }
}
