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
    public class World : DrawableGameComponent
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

        readonly List<Level> levels = new List<Level>();
        int currentLevel = -1;

        public List<Level> Levels
        {
            get
            {
                return levels;
            }
        }

        public int CurrentLevel
        {
            get
            {
                return currentLevel;
            }
            set
            {
                if (value < 0 || value >= levels.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                if (levels[value] == null)
                {
                    throw new NullReferenceException();
                }

                currentLevel = value;
            }
        }

        #endregion

        #region Constructor region

        public World(Game game, Rectangle screenRectangle)
            : base(game)
        {
            screenRect = screenRectangle;
        }

        #endregion

        #region Method region

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

        public void DrawLevel(SpriteBatch spriteBatch, Camera camera)
        {
            levels[currentLevel].Draw(spriteBatch, camera);
        }

        #endregion
    }
}
