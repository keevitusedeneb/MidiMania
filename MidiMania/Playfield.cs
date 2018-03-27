using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    class Playfield
    {
        public List<Lane> lanes { get; set; }
        public Judge judge { get; set; }
        public JudgmentRenderer renderer { get; set; }
        public float width;
        public float posX;


        public Playfield()
        {

        }

    }
}
