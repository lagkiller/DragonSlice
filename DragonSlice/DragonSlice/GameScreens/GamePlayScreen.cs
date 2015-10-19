using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using XRpgLibrary;
using XRpgLibrary.TileEngine;
using XRpgLibrary.SpriteClasses;
using XRpgLibrary.WorldClasses;

using DragonSlice.Components;

namespace DragonSlice.GameScreens
{
    public class GamePlayScreen : BaseGameState
    {
        #region Field region

        Engine engine = new Engine(32, 32);
        static Player player;
        static World world;

        #endregion

        #region Property region

        public static World World
        {
            get
            {
                return world;
            }
            set
            {
                world = value;
            }
        }

        public static Player Player
        {
            get
            {
                return player;
            }
            set
            {
                player = value;
            }
        }

        #endregion

        #region Constructor region

        public GamePlayScreen(Game game, GameStateManager manager)
            : base(game, manager)
        {
            
        }

        #endregion

        #region XNA method region

        public override void Initialize()
        {
            base.Initialize();

            player.Camera.LockToSprite(player.Sprite);
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            world.Update(gameTime);
            player.Update(gameTime);
            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            GameRef.SpriteBatch.Begin(
                SpriteSortMode.Deferred,
                BlendState.AlphaBlend,
                SamplerState.PointClamp,
                null,
                null,
                null,
                player.Camera.Transformation);

            base.Draw(gameTime);

            world.DrawLevel(gameTime, GameRef.SpriteBatch, player.Camera);
            player.Draw(gameTime, GameRef.SpriteBatch);

            GameRef.SpriteBatch.End();
        }

        #endregion

        #region Abstract method region



        #endregion
    }
}
