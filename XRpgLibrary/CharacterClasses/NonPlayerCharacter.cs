﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XRpgLibrary.SpriteClasses;

using XRpgLibrary.CharacterClasses;
using XRpgLibrary.ConversationClasses;
using XRpgLibrary.QuestClasses;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XRpgLibrary.CharacterClasses
{
    public class NonPlayerCharacter : Character
    {
        #region Field region

        readonly List<Conversation> conversations;
        readonly List<Quest> quests;

        #endregion

        #region Property region

        public List<Conversation> Conversations
        {
            get
            {
                return conversations;
            }
        }

        public List<Quest> Quests
        {
            get
            {
                return quests;
            }
        }

        public bool HasConversation
        {
            get
            {
                return (conversations.Count > 0);
            }
        }

        public bool HasQuest
        {
            get
            {
                return (quests.Count > 0);
            }
        }

        #endregion

        #region Constructor region

        public NonPlayerCharacter(Entity entity, AnimatedSprite sprite)
            : base(entity, sprite)
        {
            conversations = new List<Conversation>();
            quests = new List<Quest>();
        }

        #endregion

        #region Method region



        #endregion

        #region Virtual Method region

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }

        #endregion

    }
}
