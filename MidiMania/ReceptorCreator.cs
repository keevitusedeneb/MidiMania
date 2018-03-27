using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    static class ReceptorCreator
    {

        public static Receptor createReceptor(int i, float posX)
        {
            return new Receptor()
            {
                texture = AssetLoader.receptor,
                rotation = Helper.Rotations[i % 4],
                origin = new Vector2(AssetLoader.receptor.Width/2,AssetLoader.receptor.Height/2),
                position = new Vector2(posX+(AssetLoader.receptor.Width/2*Helper.calculateScalars()), Settings.height - AssetLoader.receptor.Height)
            };
        }

    }
}
