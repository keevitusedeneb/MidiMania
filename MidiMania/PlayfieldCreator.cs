using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    static class PlayfieldCreator
    {


        public static Playfield createPlayfield(float width, float posX)
        {
            return new Playfield()
            {
                width = width,
                posX = posX,
                judge = new Judge(),
                renderer = new JudgmentRenderer(),
                lanes = LaneCreator.createLanes(posX)
                
            };
        }
    }
}
