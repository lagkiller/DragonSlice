using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XRpgLibrary.TileEngine;
using XRpgLibrary.CharacterClasses;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XRpgLibrary.WorldClasses
{
    public class Level
    {
        #region Field region

        readonly TileMap map;
        readonly List<Character> characters;

        #endregion

        #region Property region

        public TileMap Map
        {
            get
            {
                return map;
            }
        }

        public List<Character> Characters
        {
            get
            {
                return characters;
            }
        }

        #endregion

        #region Constructor region

        public Level(TileMap tileMap)
        {
            map = tileMap;
            characters = new List<Character>();
        }

        #endregion

        #region Method region

        public void Update(GameTime gameTime)
        {
            foreach (Character character in characters)
            {
                character.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Camera camera)
        {
            map.Draw(spriteBatch, camera);
            foreach(Character character in characters)
            {
                character.Draw(gameTime, spriteBatch);
            }
        }

        #endregion
    }
}
