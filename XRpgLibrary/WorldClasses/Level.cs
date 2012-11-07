using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XRpgLibrary.TileEngine;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XRpgLibrary.WorldClasses
{
    public class Level
    {
        #region Field region

        readonly TileMap map;

        #endregion

        #region Property region

        public TileMap Map
        {
            get
            {
                return map;
            }
        }

        #endregion

        #region Constructor region

        public Level(TileMap tileMap)
        {
            map = tileMap;
        }

        #endregion

        #region Method region

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            map.Draw(spriteBatch, camera);
        }

        #endregion
    }
}
