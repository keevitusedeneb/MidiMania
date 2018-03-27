using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace MidiMania
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        AssetLoader assetLoader;
        MidiParser parser = new MidiParser();
        Metronome metronome;
        List<Playfield> playfields = new List<Playfield>();
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            


            assetLoader = new AssetLoader();
            parser.parseMidi();
            metronome = new Metronome(parser.getTempoMap());
            metronome.openOutputDevice();

            settingsParser settings = new settingsParser();

            settings.parseAndTransferSettings();



            //TargetElapsedTime = TimeSpan.FromSeconds(1 / 250f);

            Settings.applySettings(graphics,this);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            assetLoader.loadJudgments(this.Content);
            assetLoader.loadLnAssets(this.Content);
            assetLoader.loadReceptor(this.Content);
            assetLoader.loadNoteTextures(this.Content);

            playfields.Add(PlayfieldCreator.createPlayfield(Helper.playfieldWidthCalculator(),Helper.playfieldCenterCalculator()));

            Helper.assignScalars();
            
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            metronome.playASheet(parser.getNotes());
            Clock.elapsedTime += gameTime.ElapsedGameTime.TotalMilliseconds;
            Clock.timeSinceLastUpdate = gameTime.ElapsedGameTime.TotalMilliseconds;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            foreach (var item in playfields)
            {
                foreach (var lane in item.lanes)
                {
                    lane.receptor.Draw(this.spriteBatch);
                }
            }


            base.Draw(gameTime);
        }
    }
}
