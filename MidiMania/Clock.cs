using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    static class Clock
    {
        public static double elapsedTime { get; set; }
        public static double timeSinceLastUpdate { get; set; }
        public static bool stop = true;

        public static double getElapsedTime()
        {
            return elapsedTime;
        }

        public static void reset()
        {
            elapsedTime = 0;
        }

        public static double getTimeSinceLastUpdate()
        {
            return timeSinceLastUpdate;
        }

        

    }
}
