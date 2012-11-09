using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using RpgLibrary.ItemClasses;
using XRpgLibrary.SpriteClasses;

namespace XRpgLibrary.ItemClasses
{
    public class ItemSprite
    {
        #region Field region

        BaseSprite sprite;
        BaseItem item;

        #endregion

        #region Property region

        public BaseSprite Sprite
        {
            get
            {
                return sprite;
            }
        }

        public BaseItem Item
        {
            get
            {
                return item;
            }
        }

        #endregion

        #region Constructor region

        public ItemSprite(BaseItem item, BaseSprite sprite)
        {
            this.item = item;
            this.sprite = sprite;
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region

        public virtual void Update(GameTime gameTime)
        {
            sprite.Update(gameTime);
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            sprite.Draw(gameTime, spriteBatch);
        }

        #endregion

    }
}