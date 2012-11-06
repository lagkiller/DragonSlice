using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using RpgLibrary.CharacterClasses;
using RpgLibrary.ItemClasses;

using XRpgLibrary.TileEngine;
using XRpgLibrary.SpriteClasses;

namespace XRpgLibrary.WorldClasses
{
    public class World
    {
        #region Graphic Field and Property region

        Rectangle screenRect;

        public Rectangle ScreenRectangle
        {
            get
            {
                return screenRect;
            }
        }

        #endregion

        #region Item Field and Property region

        ItemManager itemManager = new ItemManager();

        #endregion

        #region Level Field and Property region



        #endregion

        #region Constructor region

        public World(Rectangle screenRectangle)
        {
            screenRect = screenRectangle;
        }

        #endregion

        #region Method region

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

        }

        #endregion
    }
}
