using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using XRpgLibrary;

using DragonSlice.GameScreens;
using DragonSlice.Components;

namespace DragonSlice
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        #region XNA Field region

        GraphicsDeviceManager graphics;
        public SpriteBatch SpriteBatch;
        public CharacterGeneratorScreen CharacterGeneratorScreen;
        public SkillScreen SkillScreen;
        public LoadGameScreen LoadGameScreen;

        #endregion

        #region FPS Field region

        private float fps;
        private float updateInterval = 1.0f;
        private float timeSinceLastUpdate = 0.0f;
        private float frameCount = 0;

        #endregion

        #region Game State region

        GameStateManager stateManager;
        public TitleScreen TitleScreen;
        public StartMenuScreen StartMenuScreen;
        public GamePlayScreen GamePlayScreen;

        #endregion

        #region Screen Field region

        const int screenWidth = 1024;
        const int screenHeight = 768;

        public readonly Rectangle ScreenRectangle;

        #endregion

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;

            ScreenRectangle = new Rectangle(
                0,
                0,
                screenWidth,
                screenHeight);

            Content.RootDirectory = "Content";

            Components.Add(new InputHandler(this));

            stateManager = new GameStateManager(this);
            Components.Add(stateManager);

            TitleScreen = new TitleScreen(this, stateManager);
            StartMenuScreen = new GameScreens.StartMenuScreen(this, stateManager);
            GamePlayScreen = new GameScreens.GamePlayScreen(this, stateManager);
            CharacterGeneratorScreen = new CharacterGeneratorScreen(this, stateManager);
            LoadGameScreen = new LoadGameScreen(this, stateManager);
            SkillScreen = new SkillScreen(this, stateManager);

            stateManager.ChangeState(TitleScreen);

            //use this for testing on slow comps
            /**
            this.IsFixedTimeStep = false;
            graphics.SynchronizeWithVerticalRetrace = false;
             * **/
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            SpriteBatch = new SpriteBatch(GraphicsDevice);

            DataManager.ReadEntityData(Content);

            DataManager.ReadArmorData(Content);
            DataManager.ReadShieldData(Content);
            DataManager.ReadWeaponData(Content);

            DataManager.ReadChestData(Content);
            DataManager.ReadKeyData(Content);

            DataManager.ReadSkillData(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);

            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            frameCount++;
            timeSinceLastUpdate += elapsed;

            if (timeSinceLastUpdate > updateInterval)
            {
                fps = frameCount / timeSinceLastUpdate;

#if XBOX360
                System.Diagnostics.Debug.WriteLine("FPS: " + fps.ToString());
#else
                this.Window.Title = "FPS: " +fps.ToString();
#endif
                frameCount = 0;
                timeSinceLastUpdate -= updateInterval;
            }
        }
    }
}
