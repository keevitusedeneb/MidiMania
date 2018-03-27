using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    class Settings
    {
        public static void applySettings(GraphicsDeviceManager graphics, Game game)
        {
            graphics.HardwareModeSwitch = !borderless;
            graphics.SynchronizeWithVerticalRetrace = vSync;
            graphics.PreferredBackBufferHeight = height;
            graphics.PreferredBackBufferWidth = width;
            graphics.IsFullScreen = fullscreen;
            game.IsFixedTimeStep = limitedFps;
            graphics.ApplyChanges();
        }

        public static float scrollSpeed = 1f;
        public static float songSpeed = 1f;
        public static bool fullscreen = false;
        public static float judgeDifficulty = 4f;
        public static int keyAmount = 4;
        public static int height = 800;
        public static int width = 600;
        public static string Seed = "Indigowizdom";
        public static bool vSync = true;
        public static bool limitedFps = false;
        public static bool borderless = true;
        public static int playerAmount = 1;
        public static bool keySounded = false;
        public static short volume = 100;

        //public enum Mode
        //{
        //    Classic = 4,
        //    TwoHanded = 8,
        //    SevenKey = 7,
        //    Melody = 4,
        //    Beat = 4
        //}

        public static Keys[] keys8 = {
            Keys.Z,
            Keys.X,
            Keys.C,
            Keys.V,
            Keys.N,
            Keys.M,
            Keys.OemComma,
            Keys.OemPeriod
        };

        public static Keys[] keys7 = {
            Keys.Z,
            Keys.X,
            Keys.C,
            Keys.Space,
            Keys.M,
            Keys.OemComma,
            Keys.OemPeriod
        };

        public static Keys[] keys6 = {
            Keys.Z,
            Keys.X,
            Keys.C,
            Keys.N,
            Keys.M,
            Keys.OemComma,
        };

        public static Keys[] keys5 = {
            Keys.X,
            Keys.C,
            Keys.Space,
            Keys.M,
            Keys.OemComma,
        };

        public static Keys[] keys4 = {
            Keys.X,
            Keys.C,
            Keys.M,
            Keys.OemComma,
        };

        public static Keys[] keys3 = {
            Keys.X,
            Keys.Space,
            Keys.OemComma,
        };
        public static Keys[] keys2 = {
            Keys.X,
            Keys.OemComma,
        };
        public static Keys[] keys1 = {
            Keys.X,
        };

        public static Dictionary<string, Keys[]> keyGroups = new Dictionary<string, Keys[]>
        {
            {"1K",keys1},
            {"2K",keys2},
            {"3K",keys3},
            {"4K",keys4},
            {"5K",keys5},
            {"6K",keys6},
            {"7K",keys7},
            {"8K",keys8},
        };


    }
}

