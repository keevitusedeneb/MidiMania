using Melanchall.DryWetMidi.Smf.Interaction;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    static class Helper
    {
        public static float[] Rotations =
        {
            MathHelper.PiOver2,
            2 *MathHelper.Pi,
            MathHelper.Pi,
            -MathHelper.PiOver2
        };

        public static float timeConversion(long noteTime, TempoMap tempoMap)
        {
            return TimeConverter.ConvertTo<MetricTimeSpan>(noteTime,tempoMap).TotalMicroseconds / 1000;
        }

        public static float playfieldWidthCalculator()
        {
            return (AssetLoader.receptor.Width * Settings.keyAmount) * calculateScalars();
        }

        public static float laneWidthCalculator()
        {
            return playfieldWidthCalculator() / Settings.keyAmount;
        }

        public static float allPlayfieldsWidthCalculator()
        {
            return (Settings.playerAmount * playfieldWidthCalculator());
        }

        public static float calculateScalars()
        {
            if (Settings.playerAmount * AssetLoader.receptor.Width * Settings.keyAmount > Settings.width * 0.75f)
            {
                return ((Settings.width * 0.75f) / (Settings.playerAmount * Settings.keyAmount)) / AssetLoader.receptor.Width;
            }
            else
            {
                return 1;
            }
        }

        public static void assignScalars()
        {
            Receptor.scalar = calculateScalars();
            VisualNote.scalar = calculateScalars();
        }

        public static float playfieldCenterCalculator()
        {
            return Settings.width / 2 - playfieldWidthCalculator() / 2;
        }
    }
}
