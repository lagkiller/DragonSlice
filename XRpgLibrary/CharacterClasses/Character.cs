using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XRpgLibrary.CharacterClasses;

using XRpgLibrary.SpriteClasses;
using XRpgLibrary.ItemClasses;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XRpgLibrary.CharacterClasses
{
    public class Character
    {
        #region Field region

        protected Entity entity;
        protected AnimatedSprite sprite;

        protected GameItem head;
        protected GameItem body;
        protected GameItem hands;
        protected GameItem feet;

        protected GameItem mainHand;
        protected GameItem offHand;

        protected int handsFree;

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

        public GameItem Head
        {
            get
            {
                return head;
            }
        }

        public GameItem Body
        {
            get
            {
                return body;
            }
        }

        public GameItem Hands
        {
            get
            {
                return hands;
            }
        }

        public GameItem Feet
        {
            get
            {
                return feet;
            }
        }

        public GameItem MainHand
        {
            get
            {
                return mainHand;
            }
        }

        public GameItem OffHand
        {
            get
            {
                return offHand;
            }
        }

        public int HandsFree
        {
            get
            {
                return handsFree;
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

        public virtual bool Equip(GameItem gameItem)
        {
            bool success = false;

            return success;
        }

        public virtual bool Unequip(GameItem gameItem)
        {
            bool success = false;

            return success;
        }

        #endregion

    }
}
