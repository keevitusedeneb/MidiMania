using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    class settingsParser
    {
        private userSettings userSettings = new userSettings();

        public void parseAndTransferSettings()
        {
            transfer(parseSettings());
        }


        private bool parseSettings()
        {
            Settings settings = new Settings();

            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

            if (!File.Exists(folder + @"\settings.json"))
            {
                

                using (StreamWriter file = File.CreateText(folder + @"\settings.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, userSettings);
                }

                return false;
            }
            else
            {
                using (StreamReader file = File.OpenText(folder + @"\settings.json"))
                {
                    userSettings = new userSettings();
                    JsonSerializer serializer = new JsonSerializer();
                    userSettings = (userSettings)serializer.Deserialize(file, typeof(userSettings));
                }

                return true;
            }
        }

        private void transfer(bool write)
        {
            if (!write) return;
                
                if (userSettings.volume > 0 && userSettings.volume <= 100)
                {
                    Settings.volume = userSettings.volume;
                }
                Settings.borderless = userSettings.borderless;
                Settings.fullscreen = userSettings.fullscreen;
                Settings.height = userSettings.height;
                if (!(userSettings.judgeDifficulty > 10 || userSettings.judgeDifficulty < 0))
                {
                    Settings.judgeDifficulty = userSettings.judgeDifficulty;
                }
                if (!(userSettings.keyAmount > 8 || userSettings.keyAmount < 1))
                {
                    Settings.keyAmount = userSettings.keyAmount;
                }
                Settings.keySounded = userSettings.keySounded;
                Settings.limitedFps = userSettings.limitedFps;
                if (!(userSettings.playerAmount < 1))
                {
                    Settings.playerAmount = userSettings.playerAmount;
                }
                if (!(userSettings.scrollSpeed <= 0))
                {
                    Settings.scrollSpeed = userSettings.scrollSpeed;
                }
                Settings.Seed = userSettings.Seed;
                if (!(userSettings.songSpeed <= 0))
                {
                    Settings.songSpeed = userSettings.songSpeed;
                }
                Settings.vSync = userSettings.vSync;
                Settings.width = userSettings.width;
                Settings.keys1 = userSettings.keys1;
                Settings.keys2 = userSettings.keys2;
                Settings.keys3 = userSettings.keys3;
                Settings.keys4 = userSettings.keys4;
                Settings.keys5 = userSettings.keys5;
                Settings.keys6 = userSettings.keys6;
                Settings.keys7 = userSettings.keys7;
                Settings.keys8 = userSettings.keys8;

            userSettings = null;
        }

    }
}
