using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    class userSettings
    {
        public float scrollSpeed = 1f;
        public float songSpeed = 1f;
        public bool fullscreen = true;
        public float judgeDifficulty = 4f;
        public int keyAmount = 4;
        public int height = 1024;
        public int width = 1280;
        public string Seed = "Indigowizdom";
        public bool vSync = true;
        public bool limitedFps = false;
        public bool borderless = true;
        public int playerAmount = 1;
        public bool keySounded = false;
        public short volume = 100;

        //public enum Mode
        //{
        //    Classic = 4,
        //    TwoHanded = 8,
        //    SevenKey = 7,
        //    Melody = 4,
        //    Beat = 4
        //}

        public Keys[] keys8 = {
            Keys.Z,
            Keys.X,
            Keys.C,
            Keys.V,
            Keys.N,
            Keys.M,
            Keys.OemComma,
            Keys.OemPeriod
        };

        public Keys[] keys7 = {
            Keys.Z,
            Keys.X,
            Keys.C,
            Keys.Space,
            Keys.M,
            Keys.OemComma,
            Keys.OemPeriod
        };

        public Keys[] keys6 = {
            Keys.Z,
            Keys.X,
            Keys.C,
            Keys.N,
            Keys.M,
            Keys.OemComma,
        };

        public Keys[] keys5 = {
            Keys.X,
            Keys.C,
            Keys.Space,
            Keys.M,
            Keys.OemComma,
        };

        public Keys[] keys4 = {
            Keys.X,
            Keys.C,
            Keys.M,
            Keys.OemComma,
        };

        public Keys[] keys3 = {
            Keys.X,
            Keys.Space,
            Keys.OemComma,
        };
        public Keys[] keys2 = {
            Keys.X,
            Keys.OemComma,
        };
        public Keys[] keys1 = {
            Keys.X,
        };

    }
}
