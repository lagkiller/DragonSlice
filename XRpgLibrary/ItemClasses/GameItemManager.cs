using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using XRpgLibrary.ItemClasses;

namespace XRpgLibrary.ItemClasses
{
    public class GameItemManager
    {
        #region Field region

        readonly Dictionary<string, GameItem> gameItems = new Dictionary<string, GameItem>();
        static SpriteFont spriteFont;

        #endregion

        #region Property region

        public Dictionary<string, GameItem> GameItems
        {
            get
            {
                return gameItems;
            }
        }

        public static SpriteFont SpriteFont
        {
            get
            {
                return spriteFont;
            }
            private set
            {
                spriteFont = value;
            }
        }

        #endregion

        #region Constructor region

        public GameItemManager(SpriteFont spriteFont)
        {
            SpriteFont = spriteFont;
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region



        #endregion

    }
}
