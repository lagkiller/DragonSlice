using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RpgLibrary.CharacterClasses;
using XRpgLibrary.SpriteClasses;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XRpgLibrary.CharacterClasses
{
    public class Character
    {
        #region Field region

        protected Entity entity;
        protected AnimatedSprite sprite;

        #endregion

        #region Property region

        public Entity Entity
        {
            get
            {
                return entity;
            }
        }

        public AnimatedSprite Sprite
        {
            get
            {
                return sprite;
            }
        }

        #endregion

        #region Constructor region

        public Character(Entity entity, AnimatedSprite sprite)
        {
            this.entity = entity;
            this.sprite = sprite;
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region

        public virtual void Update(GameTime gameTime)
        {
            entity.Update(gameTime.ElapsedGameTime);
            sprite.Update(gameTime);
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            sprite.Draw(gameTime, spriteBatch);
        }

        #endregion

    }
}
